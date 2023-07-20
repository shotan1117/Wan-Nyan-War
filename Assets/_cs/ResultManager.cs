using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ResultManager : MonoBehaviour
{
    public int p1_score = 0;
    public int p2_score = 0;
    int timeCnt = 0;
    //int cnt = 0;
    Text txt_point;
    Text txt_1P;
    Text txt_2P;
    Text txt_winner;
    Text txt_winner_Player;
    Text txt_1p_point;
    Text txt_2p_point;
    AudioSource audioSource;
    public AudioClip nyan1;
    public AudioClip nyan2;
    public AudioClip nyan3;
    public AudioClip nyan4;
    // Start is called before the first frame update
    void Start()
    {
        p1_score = PlayerPrefs.GetInt("p1Score");
        p2_score = PlayerPrefs.GetInt("p2Score");
        txt_point = GameObject.Find("Canvas").transform.Find("Point").GetComponent<Text>();
        txt_1P = GameObject.Find("Canvas").transform.Find("1P").GetComponent<Text>();
        txt_2P = GameObject.Find("Canvas").transform.Find("2P").GetComponent<Text>();
        txt_winner = GameObject.Find("Canvas").transform.Find("Winner").GetComponent<Text>();
        txt_winner_Player = GameObject.Find("Canvas").transform.Find("Winner_Player").GetComponent<Text>();
        txt_1p_point = GameObject.Find("Canvas").transform.Find("1P_Point").GetComponent<Text>();
        txt_2p_point = GameObject.Find("Canvas").transform.Find("2P_Point").GetComponent<Text>();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        this.timeCnt++;
        if(this.timeCnt == 30)
        {
            audioSource.PlayOneShot(nyan4);
            txt_point.text = "得点は・・・";
        }
        if(this.timeCnt == 90)
        {
            audioSource.PlayOneShot(nyan1);
            txt_1P.text = "1P";
            txt_2P.text = "2P";
        }
        if(this.timeCnt ==  150)
        {
            audioSource.PlayOneShot(nyan2);
            txt_1p_point.text = p1_score.ToString();
            txt_2p_point.text = p2_score.ToString();
        }
        if(this.timeCnt == 210)
        {
            if (p1_score > p2_score)
            {
                audioSource.PlayOneShot(nyan1);
                txt_winner.text = "勝者は・・・";
                txt_winner_Player.text = "1P";
            }
            else if(p1_score < p2_score)
            {
                audioSource.PlayOneShot(nyan2);
                txt_winner.text = "勝者は・・・";
                txt_winner_Player.text = "2P";
            }
            else
            {
                audioSource.PlayOneShot(nyan3);
                txt_winner.text = "引き分け";
                txt_winner_Player.text = "";
            }
        }
        if(this.timeCnt > 270)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Ending");
            }
        }
            
    }
}
