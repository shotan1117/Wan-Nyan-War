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
    private float bomTime;

    // Update is called once per frame
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
                    Shottime = 0;
                }
            }
            else if(Input.GetButtonDown("LB" + playerNo))
            {
                if(bomTime >= 10)
                {
                    Instantiate(ShotBom, transform.position, Quaternion.identity);
                    ShotBom.GetComponent<Rigidbody>().velocity = (transform.up * 300 + transform.forward * 300);
                    bomTime = 0;
                }
                
            }
        }
        

    }
}
