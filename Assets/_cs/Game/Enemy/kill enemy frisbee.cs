using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killenemyfrisbee : MonoBehaviour
{
    int killAmt = 4;
    public int scores;
    public int from;
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
            if(from==1)
            {
                ScoreManager.AddP1Score(50);

            }
            else if(from==2)
            {
                ScoreManager.AddP2Score(50);
            }
            
            killAmt--;
        }

       
    }
   
}
