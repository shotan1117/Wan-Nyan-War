using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyCheckHit : MonoBehaviour
{
    bool flag = false;
    private float timeCnt = 0;
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
        if (this.flag == false)
        {
            if (other.gameObject.CompareTag("Shot"))
            {
                GetComponent<ParticleSystem>().Play();
                animator.SetBool("Die", true);
                this.flag = true;
                this.timeCnt += Time.deltaTime;
                
            }
        }
        if(other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Attack", true);
        }
    }
}
