using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frisbeefly : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 500, 500));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Wall")
        {
            
            rb.AddForce(Vector3.up*200);
        }
        
    }
}
