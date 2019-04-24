using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextstar3 : MonoBehaviour
{
    GameObject star;
    public star script;
    // Start is called before the first frame update
    void Start()
    {
        star = GameObject.Find("star");
        script = star.GetComponent<star>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.nextstar[3] == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (script.nextstar[3] == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        if (script.nextstar[3] == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
