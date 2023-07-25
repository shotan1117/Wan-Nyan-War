using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheckHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
       
        if (other.gameObject.CompareTag("Shot"))
        {
            Debug.Log("a");
            GetComponent<ParticleSystem>().Play();
           // Destroy(gameObject);
        }
    }
}
