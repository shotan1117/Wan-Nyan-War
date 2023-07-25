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
            Destroy(other.gameObject);
            if (from == 1)
            {
                int i = PlayerPrefs.GetInt("p1Score");
                PlayerPrefs.SetInt("p1Score", i + 50);

            }
            else if (from == 2)
            {
                int i = PlayerPrefs.GetInt("p2Score");
                PlayerPrefs.SetInt("p2Score", i + 50);
            }
            //eff
            Destroy(this.gameObject);
        }
        

       

    }
}
