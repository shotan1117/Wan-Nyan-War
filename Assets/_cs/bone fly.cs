using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonefly : MonoBehaviour
{
    public float shotSpeed;
    public int playerNo;
    Rigidbody rb;
    Vector3 v;
    Transform t;
    bool forwardFlag = true;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
       t= GameObject.Find("player" + playerNo.ToString()).GetComponent<Transform>();
        v = t.forward;
    }

    // Update is called once per frame
    void Update()
    { 
        //rb.AddForce(v * shotSpeed);  
    }

    private void FixedUpdate()
    {
         rb.AddForce(v * shotSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "")
        {
            forwardFlag = false;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
