using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCannon : MonoBehaviour
{
    public GameObject shellPrefab;
    GameObject star;
    public star script;
    public float shotSpeed;
    public float DestoryTime;
    internal bool Hit;
    public int shotbegin;
   void Start()
    {
        Hit = false;
        shotbegin = 1;
        star = GameObject.Find("star");
        script = star.GetComponent<star>();
    }

    void Update()
    {
        // もしもSpaceキーを押したならば（条件）
        // 「Space」の部分を変更することで他のキーにすることができる（ポイント）
        if (script.beforestarmode == 0)
        {
            if (shotbegin == 1)
            {
                if (Input.GetKey("up"))
                {
                    // 砲弾のプレハブを実体化（インスタンス化）する。
                    GameObject Cannon = Instantiate(shellPrefab, transform.position, Quaternion.identity) as GameObject;

                    // 砲弾に付いているRigidbodyコンポーネントにアクセスする。
                    Rigidbody CannonRb = Cannon.GetComponent<Rigidbody>();

                    // forward（青軸＝Z軸）の方向に力を加える。
                    CannonRb.AddForce(transform.forward * shotSpeed);

                    // 発射した砲弾を３秒後に破壊する。
                    // （重要な考え方）不要になった砲弾はメモリー上から削除すること。
                    Destroy(Cannon, DestoryTime);
                    shotbegin = 0;
                }
            }
            if (shotbegin == 2)
            {
                if (Input.GetKey("up"))
                {
                    // 砲弾のプレハブを実体化（インスタンス化）する。
                    GameObject Cannon = Instantiate(shellPrefab, transform.position, Quaternion.identity) as GameObject;

                    // 砲弾に付いているRigidbodyコンポーネントにアクセスする。
                    Rigidbody CannonRb = Cannon.GetComponent<Rigidbody>();

                    // forward（青軸＝Z軸）の方向に力を加える。
                    CannonRb.AddForce(transform.forward * shotSpeed);

                    // 発射した砲弾を３秒後に破壊する。
                    // （重要な考え方）不要になった砲弾はメモリー上から削除すること。
                    Destroy(Cannon, DestoryTime);
                    shotbegin = 0;
                }
            }
        }
        if (script.starmode == 0)
        {
            shotbegin = 1;
        }
        if (script.beforestarmode == 0)
        {
            if (script.starmode == 0)
            {
                shotbegin = 2;
            }
        }
        if (script.twobeforestarmode == 0)
        {
            if (script.beforestarmode == 0)
            {
                if (script.starmode == 0)
                {
                    shotbegin = 3;
                }
            }
        }
    }
    
}
