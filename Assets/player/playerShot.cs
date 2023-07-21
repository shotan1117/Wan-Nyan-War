using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShot : MonoBehaviour
{
    public player_invincible player_invincible;
    [SerializeField]
    int playerNo;
    public GameObject Shot;
    private bool hitchack;
    private int shotcount=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        shotcount++;
        hitchack = player_invincible.invincibleCkack;
        if (!hitchack)
        {
           // if (shotcount % 60 == 0)
            {
                if (Input.GetButton("RB" + playerNo))
                {
                    Debug.Log(playerNo);
                    
                        Instantiate(Shot, transform.position, Quaternion.identity);
                    
                }
            }
        }
    }
}
