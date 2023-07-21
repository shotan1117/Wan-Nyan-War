using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killenemybone : MonoBehaviour
{
    public int scores;
    // Start is called before the first frame update
 

    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.tag=="enemy")
        {
            Destroy(other.gameObject);
            scores += 50;
            //eff
            Destroy(this.gameObject);
        }
        

       

    }
}
