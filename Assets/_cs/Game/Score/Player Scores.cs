using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScores : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.SetP1Score(0);
        ScoreManager.SetP2Score(0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
