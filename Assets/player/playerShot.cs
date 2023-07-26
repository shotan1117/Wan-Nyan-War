using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShot : MonoBehaviour
{
    public player_invincible player_invincible;
    [SerializeField]
   private int playerNo;
    public GameObject Shot;
    private bool hitchack;
    private float shotcount;
    Rigidbody shotRb;
    // Start is called before the first frame update
    void Start()
    {
        shotRb = Shot.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      
        shotcount+=Time.deltaTime;
        hitchack = player_invincible.invincibleCkack;
      //  if (!hitchack)
        {
           // if(shotcount  ==5)
            {

                string buttonName = "RB" + playerNo;
                if (Input.GetButtonDown(buttonName))
                {
                    Shot.GetComponent<killenemybone>().from = playerNo;
                        Instantiate(Shot, transform.position, Quaternion.identity);
                   
                }
            }
        }
    }
}
