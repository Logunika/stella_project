using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetrium : MonoBehaviour {
    public GameObject targetObject;
    public float valueHorizontal;
    public float valueVertical;
    public float planetrium_angle;
    public float planetrium_rotation;

    // Use this for initialization
    void Start () {
        planetrium_angle = 0;
        planetrium_rotation = 0;
	}
	
	// Update is called once per frame
	void Update () {
        valueHorizontal = Input.GetAxis("Horizontal");
        valueVertical = Input.GetAxis("Vertical");
        if (Input.GetKey("right"))
        {
            transform.Rotate(new Vector3(0, 2, 0));
            planetrium_angle += 2;
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(new Vector3(0, -2, 0));
            planetrium_angle -= 2;
        }
        gameObject.transform.position = new Vector3(targetObject.transform.position.x, 0, targetObject.transform.position.z);
    }

    public float Get_planetrium_rotation()
    {
        planetrium_rotation = planetrium_angle - planetrium_rotation;
        return planetrium_rotation;
    }
}
