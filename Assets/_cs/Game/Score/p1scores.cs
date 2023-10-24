using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1scores : MonoBehaviour
{
    int p1score;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        p1score = ScoreManager.GetP1Score();
        text.text = "p1:" + p1score.ToString() + "“_";
    }
}
