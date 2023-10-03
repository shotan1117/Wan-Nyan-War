using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinChack : MonoBehaviour
{
   private int coincount = 0;
    public int Coincount() {return coincount;}
    void Update()
    {
        Debug.Log("player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            ScoreManager.AddP1Score(1);
            Destroy(other.gameObject);
        }
    }
}
