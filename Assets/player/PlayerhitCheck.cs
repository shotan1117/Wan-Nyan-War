using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerhitCheck : MonoBehaviour
{
    private bool shotHitcheck;
    private bool hitcheck;
    private bool hitChackExit;
    public bool Hitcheck()
    {
        Debug.Log(shotHitcheck);
        if (hitcheck)
        {
            shotHitcheck = true;
        }
        else if(hitChackExit)
        {
            shotHitcheck = false;
        }

        hitcheck = false;
        hitChackExit = false;
        return shotHitcheck;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            hitcheck = true;
        }

        if (other.gameObject.tag == "Shot")
        {
            hitcheck = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            hitChackExit = true;
        }

        if (other.gameObject.tag == "Shot")
        {
            hitChackExit = true;
        }
    }
}
