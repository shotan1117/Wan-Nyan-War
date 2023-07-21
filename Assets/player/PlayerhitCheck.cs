using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerhitCheck : MonoBehaviour
{
    private bool shotHitcheck;
    private bool hitcheck;
    private bool invincibleCkeck;
    float elapsedTime;
    public bool Hitcheck()
    {
        if (hitcheck)
        {
            shotHitcheck = true;
        }
        else
        {
            shotHitcheck = false;
        }
        hitcheck = false;
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
}
