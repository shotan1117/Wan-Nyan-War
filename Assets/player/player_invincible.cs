using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_invincible : MonoBehaviour
{
    public bool invincibleCkack;
    float elapsedTime = 0;
    public int invincibleTime;
    private float BlinkDuration;
    float blinkTime;
    private Renderer[] mrList;

    [SerializeField]
    private float playerNo;


    AudioSource playerAudio;
    void Start()
    {
         mrList = GetComponentsInChildren<Renderer>();
        playerAudio = GetComponent<AudioSource>();
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

        if (other.gameObject.tag == "Coin" && !invincibleCkack)
        {

            playerAudio.Play();
            
            if (playerNo == 1)
            {
                Debug.Log("1");
                ScoreManager.AddP1Score(1);
            }
            else if (playerNo == 2)
            {
                Debug.Log("2");
                ScoreManager.AddP2Score(1);
            }
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Shot")
        {
            if (playerNo == 1)
            {
                ScoreManager.MinusP1Score(1);
            }
            else if (playerNo == 2)
            {
                ScoreManager.MinusP2Score(1);
            }
        }
    }
}