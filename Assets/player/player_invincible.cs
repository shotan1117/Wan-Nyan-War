using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_invincible : MonoBehaviour
{
    public PlayerhitCheck PlayerhitChack;
    public bool invincibleCkack;
    float elapsedTime = 0;
    public int invincibleTime;

    private bool ishitChack;
    void Update()
    {
        ishitChack = PlayerhitChack.Hitcheck();
        if(ishitChack)
        {  
            invincibleCkack = true;          
        }
       
        if (invincibleCkack == true)
        {
            elapsedTime += Time.deltaTime;
        }
        if (elapsedTime >= invincibleTime)
        {
            invincibleCkack = false;
              elapsedTime = 0;
        }
    }
}