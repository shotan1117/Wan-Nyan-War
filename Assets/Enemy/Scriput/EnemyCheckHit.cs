using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheckHit : MonoBehaviour
{
    private bool shotHitcheck;
    private bool hitcheck;
    private bool invincibleCkack;
    float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Shot")
        {
            GetComponent<ParticleSystem>().Play();
            Destroy(this.gameObject);
        }
    }
}
