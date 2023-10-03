using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinfly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(0, 250);
        int y= Random.Range(400, 700);
        int z = Random.Range(0, 250);
     
        GetComponent<Rigidbody>().AddForce(new Vector3(x,y, z));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
