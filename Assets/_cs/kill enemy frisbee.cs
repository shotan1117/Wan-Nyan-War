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
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            if(from==1)
            {
                int i =PlayerPrefs.GetInt("p1Score");
                PlayerPrefs.SetInt("p1Score", i+50);

            }
            else if(from==2)
            {
                int i = PlayerPrefs.GetInt("p2Score");
                PlayerPrefs.SetInt("p2Score", i + 50);
            }
            
            killAmt--;
        }

       
    }
   
}
