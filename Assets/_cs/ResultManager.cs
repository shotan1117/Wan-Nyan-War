using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ResultManager : MonoBehaviour
{
    int p1_score = 0;
    int p2_score = 0;
    int timeCnt = 0;
    Text txt_1p;
    Text txt_2p;
    // Start is called before the first frame update
    void Start()
    {
        txt_1p = GameObject.Find("Canvas").transform.Find("1P_Point").GetComponent<Text>();
        txt_2p = GameObject.Find("Canvas").transform.Find("2P_Point").GetComponent<Text>();



        
    }

    // Update is called once per frame
    void Update()
    {
        this.timeCnt++;

        if(this.timeCnt > 60)
        {
            txt_1p.text = p1_score.ToString();
            txt_2p.text = p2_score.ToString();
        }
    }
}
