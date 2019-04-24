using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    public GameObject targetObject;
    // Use this for initialization
    public float ship_angle;
    public float ship_rotation;
    GameObject star;
    public star script;
    void Start () {
        star = GameObject.Find("star");
        script = star.GetComponent<star>();
        ship_angle = 0;
        ship_rotation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (script.beforestarmode == 2)
        {
            if (Input.GetKey("up"))
            {
                Debug.Log(transform.localEulerAngles.y);
                Debug.Log(targetObject.transform.localEulerAngles.y);
                ship_rotation = targetObject.transform.localEulerAngles.y - transform.localEulerAngles.y;
                if (ship_rotation > 180)
                {
                    ship_rotation -= 360;
                }
                if (ship_rotation < -180)
                {
                    ship_rotation += 360;
                }
            }
            //Vector3 velocity = targetObject.transform.position;
            //gameObject.transform.position = new Vector3(velocity.x, 1,velocity.z);
        }
        if (ship_rotation > 2)
        {
            transform.Rotate(new Vector3(0, 0.5f, 0));
            ship_rotation -= 0.5f;
        }
        if (ship_rotation < -2)
        {
            transform.Rotate(new Vector3(0, -0.5f, 0));
            ship_rotation += 0.5f;
        }
        float speed = 3;
        Vector3 velocity = gameObject.transform.forward * speed;
        gameObject.transform.position += velocity * Time.deltaTime;
    }
}
