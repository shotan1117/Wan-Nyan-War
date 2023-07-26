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

    // Update is called once per frame
    void Update()
    {
        hitchack = player_invincible.invincibleCkack;
      //  if (!hitchack)
        {
                string buttonName = "RB" + playerNo;
                if (Input.GetButtonDown(buttonName))
                {
                        Instantiate(Shot, transform.position, Quaternion.identity);
                }
        }
    }
}
