using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShot : MonoBehaviour
{
    public player_invincible player_invincible;
    [SerializeField]
   private int playerNo;

    public GameObject Shot;
    public GameObject ShotBom;
    private bool hitchack;
    private float Shottime;
    public float bomTime;

    public AudioClip bonehit;
    public AudioClip bombhit;
    AudioSource ass;
    // Update is called once per frame

    private void Start()
    {
        ass=GetComponent<AudioSource>();
    }
    void Update()
    {
        
        hitchack = player_invincible.invincibleCkack;
        Shottime += Time.deltaTime;
        bomTime += Time.deltaTime;
        if (!hitchack)
        {
            if (Input.GetButton("RB" + playerNo))
            {
                if (Shottime >= 0.2f)
                {
                    Shot.GetComponent<killenemybone>().from = playerNo;
                    Instantiate(Shot, transform.position , Quaternion.identity);

                    ass.PlayOneShot(bonehit);
                    Shottime = 0;
                }
            }
            else if(Input.GetButtonDown("LB" + playerNo))
            {
                if (bomTime >= 10)
                {
                    Instantiate(ShotBom, transform.position + transform.forward *2, Quaternion.identity);

                    ass.PlayOneShot(bombhit); 
                    bomTime = 0;
                }
                
            }
        }
    }
}
