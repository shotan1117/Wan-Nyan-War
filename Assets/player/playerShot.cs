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
    private float _time;

    // Update is called once per frame
    void Update()
    {
        hitchack = player_invincible.invincibleCkack;
        _time += Time.deltaTime;
        if (!hitchack)
        {
            if (Input.GetButton("RB" + playerNo))
            {
                if (_time >= 0.2f)
                {
                    Shot.GetComponent<killenemybone>().from = playerNo;
                    Instantiate(Shot, transform.position , Quaternion.identity);
                    _time = 0;
                }
            }
            else if(Input.GetButtonDown("LB" + playerNo))
            {
                Instantiate(ShotBom, transform.position, Quaternion.identity);
            }
        }
        

    }
}
