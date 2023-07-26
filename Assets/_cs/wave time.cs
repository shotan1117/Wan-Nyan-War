using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wavetime : MonoBehaviour
{
    Text text;
    string wave;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        wave = "wave:";
    }

    // Update is called once per frame
    void Update()
    {
        
        text.text = wave + gameDirector.waveCnt + "     "+gameDirector.timeCnt.ToString("00")+"s ";
    }
}
