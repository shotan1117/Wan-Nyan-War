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

    float timeCnt=0;
    void Start()
    {
    }
    void Update()
    {
        //print(elapsedTime);
        ishitChack = PlayerhitChack.Hitcheck();
        if(ishitChack && invincibleCkack == false)
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
       
        if(elapsedTime >0)
        {
            timeCnt += Time.deltaTime;
            if(timeCnt<=0.5)
            {
                transform.localScale = Vector3.one * 0.01f;
            }
            else if(timeCnt<=1)
            {
                transform.localScale = Vector3.one;
               
            }
            else if (timeCnt>1)
            {
                timeCnt = 0;
            }
            
        }
        else
        {
            transform.localScale = Vector3.one;
        }
    }
}