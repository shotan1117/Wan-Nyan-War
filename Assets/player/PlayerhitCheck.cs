using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerhitCheck : MonoBehaviour
{
    private bool shotHitcheck;
    private bool hitcheck;
    private bool hitChackExit;

    player_invincible pi;

    private void Start()
    {
        pi = gameObject.GetComponent<player_invincible>();
    }
    public bool Hitcheck()
    {
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
    

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            hitChackExit = true;
        }
    }
}
