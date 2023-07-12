using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonefly : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0,0,500)*2.5f);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
