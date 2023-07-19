using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerhitChack : MonoBehaviour
{
    private bool shotHitchack;
    private bool hitchack;
    private bool invincibleCkack;
    float elapsedTime;
    public bool Hitchack()
    {
        if (hitchack)
        {
            shotHitchack = true;
        }
        else
        {
            shotHitchack = false;
        }
        hitchack = false;
        return shotHitchack;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            hitchack = true;
        } 
    }
}
