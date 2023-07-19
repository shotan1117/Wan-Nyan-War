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
   public bool HitCheck()
    {
        if (hitcheck)
        {
            shotHitcheck = true;
        }
        else
        {
            shotHitcheck = false;
        }
        hitcheck = false;
        return shotHitcheck;
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player")
        {
            hitcheck = true;
        }

        if (other.gameObject.tag == "Shot")
        {
            hitcheck = true;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
