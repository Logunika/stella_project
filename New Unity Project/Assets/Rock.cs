using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Start is called before the first frame update
    internal bool b_Fade;

    void Start()
    {
        b_Fade = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider ExceptIwa)
    {
        Debug.Log(ExceptIwa.gameObject.name);

        if (ExceptIwa.gameObject.tag == "Cannon")
        {
            destroyObject();
            Destroy(ExceptIwa.gameObject);
        }

        if(ExceptIwa.gameObject.tag == "ship")
        {
            Debug.Log("shipHit");
            destroyObject();
        }
        
        

    }

    public void destroyObject()
    {
        var random = new System.Random();
        var min = -3;
        var max = 3;
        gameObject.GetComponentsInChildren<Rigidbody>().ToList().ForEach(r => {
            r.isKinematic = false;
            r.transform.SetParent(null);
            r.gameObject.AddComponent<DestroyObject>().time = 5f;
            var vect = new Vector3(random.Next(min, max), random.Next(0, max), random.Next(min, max));
            r.AddForce(vect, ForceMode.Impulse);
            r.AddTorque(vect, ForceMode.Impulse);
        });

        Destroy(this.gameObject);

       

    }
}
