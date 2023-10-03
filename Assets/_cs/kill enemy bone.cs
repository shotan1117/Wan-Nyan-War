using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killenemybone : MonoBehaviour
{
    public int scores;
    public int from;
    // Start is called before the first frame update


    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.tag=="enemy")
        {
            if (from == 1)
            {
                ScoreManager.AddP1Score(50);
            }
            else if (from == 2)
            {
                ScoreManager.AddP2Score(50);
            }
          
            
        }

      
            Destroy(this.gameObject);



    }
}
