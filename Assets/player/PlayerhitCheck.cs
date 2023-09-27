using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerhitCheck : MonoBehaviour
{
    private bool isHit = false;
    private bool isEnter, isStay, isExit;
    public bool Hitcheck()
    {
        if (isEnter || isStay)
        {
            isHit = true;
        }
        else if (isExit)
        {
            isHit = false;
        }

        isEnter = false;
        isStay = false;
        isExit = false;
        return isHit;
    }
  
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            isEnter = true;
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            isStay = true;
        }
    }

    private void OnCollisionExit(Collision other)
    { 
       if (other.gameObject.tag == "enemy")
        {
            isExit = true;
        }
    }
}
