using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class shotarea : MonoBehaviour
{
    public int starmode;
    public int beginshotarea;
    GameObject star;
    public star script;
    // Start is called before the first frame update
    void Start()
    {
        star = GameObject.Find("star");
        script = star.GetComponent<star>();
        beginshotarea = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (script.starmode == 0)
        {
            if (beginshotarea == 0)
            {
                beginshotarea = 1;
                GameObject Shotarea = Instantiate(Resources.Load("Sphere 1"), transform.position, Quaternion.identity) as GameObject;
                Shotarea.transform.parent = transform;
            }
        }
        if (script.starmode == 1)
        {
            beginshotarea = 0;
            Destroy(GameObject.Find("Sphere 1(Clone)"));
        }
        if (script.starmode == 2)
        {
            beginshotarea = 0;
            Destroy(GameObject.Find("Sphere 1(Clone)"));
        }
    }
}
