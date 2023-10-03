using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_invincible : MonoBehaviour
{
    public bool invincibleCkack;
    float elapsedTime = 0;
    public int invincibleTime;
    public float BlinkDuration;
    float blinkTime;
    private Renderer[] mrList;

    float timeCnt=0;
    void Start()
    {
         mrList = GetComponentsInChildren<Renderer>();
    }

    public void Damage()
    {
        elapsedTime = 0;
        blinkTime = 0;
        invincibleCkack = true;
    }

    void InvincibleChange(bool flag)
    {
        foreach (var mr in mrList)
        {
            mr.enabled = flag;
        }
    }

    void Update()
    {
        if (!invincibleCkack) return;

        elapsedTime += Time.deltaTime;
        blinkTime += Time.deltaTime;

        // “_–ÅI—¹
        if (elapsedTime >= invincibleTime)
        {
            InvincibleChange(true);
            invincibleCkack = false;
            return;
        }

        // “_–Å
        if(blinkTime >= BlinkDuration)
        {
            blinkTime -= BlinkDuration;
            InvincibleChange(!mrList[0].enabled);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {            
                Damage();
        }
    }
}