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
        Destroy(this.gameObject);
    }
}
