using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyCheckHit : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Shot"))
        {
            GetComponent<ParticleSystem>().Play();
            animator.SetBool("Die",true);
           // Destroy(gameObject);
        }
        if(other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Attack", true);
        }
    }
}
