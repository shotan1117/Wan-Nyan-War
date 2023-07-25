using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonefly : MonoBehaviour
{
    Rigidbody rb;
    public player1 player1;
    Vector3 v;
    Transform t;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        // GameObject player1 = GameObject.Find("player1");
       t= GameObject.Find("player1").GetComponent<Transform>();
       

    }

    // Update is called once per frame
    void Update()
    {
        v = t.forward;
        rb.AddForce(v * 150f);
        
    }
}
