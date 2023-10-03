using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCoin : MonoBehaviour
{
    player1 p;
    // Start is called before the first frame update
    void Start()
    {
        p=GetComponent<player1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Coin")
        {
            if(p.playerNo==1)
            {
                ScoreManager.AddP1Score(1);
            }
            else if(p.playerNo==2)
            {
                ScoreManager.AddP2Score(1);
            }
            
            Destroy(other.gameObject);
        }
    }
}
