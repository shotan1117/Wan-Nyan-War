using Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class BossCheckHit : MonoBehaviour
{
    private bool Checkflag = false;
    private int BossHP = 0;
    private int coinGenerate = 5;
    public GameObject coin;
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

    private void OnCollisionEnter(Collision other)
    {
        if(this.Checkflag == false)
        {
            if(other.gameObject.CompareTag("Shot"))
            {
                BossHP += 1;
                Debug.Log(BossHP);
            }
            if (BossHP >= 10)
            {
                for (int i = 0; i < coinGenerate; i++)
                {
                    Vector3 v = transform.position+Vector3.up*3;
                    GameObject coinn = Instantiate(coin, v, Quaternion.identity);
                    coinn.transform.Rotate(new Vector3(67.941f, 188.771f, 0.638f));
                }

                GetComponent<ParticleSystem>().Play();
                animator.SetBool("Die", true);
                this.Checkflag = true;
                Debug.Log("Die^^");
            }
        }
    }
}
