using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombactivate : MonoBehaviour
{
     public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        bomb.GetComponent<BoxCollider>().enabled = true;
        
    }
}
