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
    public GameObject coin;
    private int coinGenerate;
    private int scoredecrease = 3;

    [SerializeField]
    private int playerNo;

    AudioSource playerAudioSource;

    public AudioClip attacked;

    [SerializeField]
    private AudioClip coinGet;
    void Start()
    {
         mrList = GetComponentsInChildren<Renderer>();
        playerAudioSource = GetComponent<AudioSource>();
    }

    private void Damage()
    {
        elapsedTime = 0;
        blinkTime = 0;
        invincibleCkack = true;
        CoinGenerate();
    }
    void CoinGenerate()
    {
        if (playerNo == 1)
        {
            
            if (ScoreManager.GetP1Score() >= scoredecrease)
            {
                coinGenerate = scoredecrease;
            }
            else
            {
                coinGenerate = ScoreManager.GetP1Score();
            }
            ScoreManager.MinusP1Score(scoredecrease);
        }
        else if (playerNo == 2)
        {
           
            if (ScoreManager.GetP2Score() > scoredecrease)
            {
                coinGenerate = scoredecrease;   
            }
            else
            {
                coinGenerate = ScoreManager.GetP2Score();
            }
            ScoreManager.MinusP2Score(scoredecrease);
        }
        for (int i = 0; i < coinGenerate; i++)
        {
            Vector3 v = transform.position/* + transform.up * 5*/;
            GameObject coinn = Instantiate(coin, v, Quaternion.identity);
            coinn.transform.Rotate(new Vector3(67.941f, 188.771f, 0.638f));
        }
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
        if (other.gameObject.tag == "enemy" && invincibleCkack ==false)
        {
            playerAudioSource.PlayOneShot(attacked);
            Damage();
        }
        
        if (other.gameObject.tag == "Shot" && invincibleCkack == false)
        {
            playerAudioSource.PlayOneShot(attacked);
            Damage();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shot" && invincibleCkack == false)
        {
            playerAudioSource.PlayOneShot(attacked);
            Damage();
        }


        if (other.gameObject.tag == "Coin" && invincibleCkack == false)
        {
            if (playerNo == 1)
            {
                ScoreManager.AddP1Score(1);
                playerAudioSource.PlayOneShot(coinGet);
            }
            else if (playerNo == 2)
            {

                ScoreManager.AddP2Score(1);
                playerAudioSource.PlayOneShot(coinGet);
            }
            Destroy(other.gameObject);
        }
    }
}