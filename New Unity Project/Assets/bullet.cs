using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public float radian;
    public float RightValueHorizontal = 1.0f;
    public float RightValueVertical = 1.0f;
    // Use this for initialization
    void Start ()
    {
        RightValueHorizontal = Input.GetAxis("RightHorizontal");
        RightValueVertical = Input.GetAxis("RightVertical");
        radian = Mathf.Atan2(RightValueVertical, RightValueHorizontal);
        Debug.Log(radian);
        Debug.Log(RightValueHorizontal);
        Debug.Log(RightValueVertical);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position -= transform.up * Time.deltaTime * 10.0f * Mathf.Sin(radian);
        transform.position += transform.right * Time.deltaTime * 10.0f * Mathf.Cos(radian);
    }
}