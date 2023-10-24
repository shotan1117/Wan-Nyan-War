using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombspeed : MonoBehaviour
{
    public int playerNo;
    Transform t;
    Vector3 v0,v1;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        t = GameObject.Find("player" + playerNo.ToString()).GetComponent<Transform>();
      
        rb.AddForce(t.forward * 100+t.up*100);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
