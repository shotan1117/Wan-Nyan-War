using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
public class EnemyCheckHit : MonoBehaviour
{
    bool flag = false;

    Animator animator;

    public GameObject coin;
    
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
                Vector3 v = transform.position + transform.up*5;


               GameObject coinn= Instantiate(coin, v, Quaternion.identity);
                coinn.transform.Rotate(new Vector3(67.941f, 188.771f, 0.638f));
                GetComponent<ParticleSystem>().Play();
                animator.SetBool("Die", true);
                this.flag = true;
              
                
            }
        }
        if(other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Attack", true);
        }
    }
}
