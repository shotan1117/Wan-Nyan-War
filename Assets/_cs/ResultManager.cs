using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ResultManager : MonoBehaviour
{
    public enum ResultState
    {
        None,
        Player1,
        Player2,
        Draw
    }
    public static ResultState resultState = ResultState.None;
    int p1_score = 0;
    int p2_score = 0;
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
        p1_score = ScoreManager.GetP1Score();
        p2_score = ScoreManager.GetP2Score();

        txt_point = GameObject.Find("Canvas").transform.Find("Point").GetComponent<Text>();
        txt_1P = GameObject.Find("Canvas").transform.Find("1P").GetComponent<Text>();
        txt_2P = GameObject.Find("Canvas").transform.Find("2P").GetComponent<Text>();
        txt_winner = GameObject.Find("Canvas").transform.Find("Winner").GetComponent<Text>();
        txt_winner_Player = GameObject.Find("Canvas").transform.Find("Winner_Player").GetComponent<Text>();
        txt_1p_point = GameObject.Find("Canvas").transform.Find("1P_Point").GetComponent<Text>();
        txt_2p_point = GameObject.Find("Canvas").transform.Find("2P_Point").GetComponent<Text>();

        audioSource = GetComponent<AudioSource>();

        StartCoroutine(PlayWinLose());
    }

    IEnumerator PlayWinLose()
    {
        yield return new WaitForSeconds(0.5f);
        
        audioSource.PlayOneShot(nyan4);
        txt_point.text = "得点は・・・";

        yield return new WaitForSeconds(1.5f);

        audioSource.PlayOneShot(nyan1);
        txt_1P.text = "1P";
        txt_2P.text = "2P";

        yield return new WaitForSeconds(1.5f);

        audioSource.PlayOneShot(nyan2);
        txt_1p_point.text = p1_score.ToString();
        txt_2p_point.text = p2_score.ToString();

        yield return new WaitForSeconds(1.5f);

        if (p1_score > p2_score)
        {
            audioSource.PlayOneShot(nyan1);
            txt_winner.text = "勝者は・・・";
            txt_winner_Player.text = "1P";
            resultState = ResultState.Player1;
        }
        else if (p1_score < p2_score)
        {
            audioSource.PlayOneShot(nyan2);
            txt_winner.text = "勝者は・・・";
            txt_winner_Player.text = "2P";
            resultState = ResultState.Player2;
        }
        else
        {
            audioSource.PlayOneShot(nyan3);
            txt_winner.text = "引き分け";
            txt_winner_Player.text = "";
            resultState = ResultState.Draw;
        }


        yield return new WaitForSeconds(1f);

        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                break;
            }
            yield return null;
        }

        SceneManager.LoadScene("Ending");
    }
}
