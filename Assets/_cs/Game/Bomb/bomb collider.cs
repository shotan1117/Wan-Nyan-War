using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombcollider : MonoBehaviour
{
    BoxCollider bc;
    // Start is called before the first frame update
    void Start()
    {
        bc=GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = bc.size.x;
        x += 1.5f*Time.deltaTime;
        if(x>8) x = 8;
        float z = bc.size.z;
        if(z>8) z = 8;
        z += 1.5f*Time.deltaTime;
        bc.size=new Vector3(x,bc.size.y,z);
     
    }
}
