using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShot : MonoBehaviour
{
    public player_invincible player_invincible;
    [SerializeField]
    int playerNo;
    private bool hitchack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hitchack = player_invincible.invincibleCkack;
        if (!hitchack)
        {
            if (Input.GetButton("RB" + playerNo))
            {
                Debug.Log("a");
            }
        }
    }
}
