using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour {
    public int starmode;
    public int beforestarmode;
    public int twobeforestarmode;
    public int wait;
    public int[] nextstar = new int[5];
    // Use this for initialization
    void Start () {
        starmode = 20;
        beforestarmode = 20;
        twobeforestarmode = 20;
        for (int i = 0; i < 5; i++)
        {
            nextstar[i] = UnityEngine.Random.Range(0, 3);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (wait == 0)
        {
            if (Input.GetKey("up"))
            {
                for (int i = 0; i < 4; i++)
                {
                    nextstar[i] = nextstar[i + 1];
                }
                nextstar[4] = UnityEngine.Random.Range(0, 3);
                twobeforestarmode = beforestarmode;
                beforestarmode = starmode;
                starmode = nextstar[0];
                wait = 30;
            }
        }
        if (wait > 0)
        {
            wait -= 1;
        }
        if (starmode == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (starmode == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        if (starmode == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
