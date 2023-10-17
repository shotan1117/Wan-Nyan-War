using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCheckHit : MonoBehaviour
{
    private bool Checkflag = false;
    private int DamageCnt = 0;
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
                DamageCnt += 1;
            }
            if(DamageCnt >= 100)
            {
                Vector3 v = transform.position + transform.up * 5;


                GameObject coinn = Instantiate(coin, v, Quaternion.identity);
                coinn.transform.Rotate(new Vector3(67.941f, 188.771f, 0.638f));

                GetComponent<ParticleSystem>().Play();
                animator.SetBool("Die", true);
                this.Checkflag = true;
            }
        }
    }
}
