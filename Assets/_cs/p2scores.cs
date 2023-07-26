using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class p2scores : MonoBehaviour
{
    int p2score;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text= GetComponent<Text>(); 

    }

    // Update is called once per frame
    void Update()
    {
        p2score = ScoreManager.GetP2Score();
        text.text= "p2:"+p2score.ToString()+"“_";
    }
}
