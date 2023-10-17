using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killenemybone : MonoBehaviour
{
    public int scores;
    public int from;
    public GameObject efffff;
    // Start is called before the first frame update


    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.tag == "enemy"||other.gameObject.tag=="Player")
        {
            Instantiate(efffff, transform.position, Quaternion.identity);
        }
        Destroy(this.gameObject);
    }
}
