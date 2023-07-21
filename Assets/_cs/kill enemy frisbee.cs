using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killenemyfrisbee : MonoBehaviour
{
    int killAmt = 4;
    public int scores;
    void Update()
    {
        if(killAmt==0)
        {
           Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
            scores += 50;
            killAmt--;
        }

       
    }
   
}
