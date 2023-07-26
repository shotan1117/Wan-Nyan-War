using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScores : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("p1Score", 0);
        PlayerPrefs.SetInt("p2Score", 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
