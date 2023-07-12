using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killenemybone : MonoBehaviour
{
    // Start is called before the first frame update
 

    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.tag=="Enemy")
        {
            Destroy(other.gameObject);

            //eff
            Destroy(this.gameObject);
        }
        

       

    }
}
