using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot2 : MonoBehaviour
{
    public player_invincible player_invincible;
    public GameObject Shot;
    private bool hitchack;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //  shotcount+=Time.deltaTime;
        hitchack = player_invincible.invincibleCkack;
        // if (!hitchack)
        {
            {
                if (Input.GetButtonDown("RB" + 2))
                {
                    Instantiate(Shot, transform.position, Quaternion.identity);
                }
            }
        }
    }
}
