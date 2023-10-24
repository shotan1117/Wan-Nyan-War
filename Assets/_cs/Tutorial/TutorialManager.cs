using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public Text explain;
    const int cnt = 8;
    string[] explainText = new string[cnt];
    float time = 0;
    int drawCnt = 0;

    public Text totitle;
    // Start is called before the first frame update
    void Start()
    {
        explainText[0] = "左スティック（Lスティック）で猫（プレイヤー）移動！\n";
        explainText[1] = "右スティック（Rスティック）でカメラ移動！\n";
        explainText[2] = "RBボタンで骨(弾)を発射。犬（敵）を追い払う！\n";
        explainText[3] = "LBボタンで煙玉を発射。犬を一網打尽！\n臭すぎて自身も食らってしまう！\n";
        explainText[4] = "waveごとに犬がいっぱい来るので追い払おう！\n追い払ったときにコインが出るからたくさん集めよう！\n";
        explainText[5] = "コインをたくさん集めた方が勝ちだ！飼い主さんに褒めてもらおう！\n";
        explainText[6] = "ダメージを食らってしまうと、コインを落として、\n一時的に骨も打てなくなってしまうぞ！\n";
        explainText[7] = "相手の猫の骨や、煙玉でもダメージを食らってしまうぞ！\n";

        totitle.text = "STARTボタンで\nタイトルへ";
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 5.0f)
        {
            time = 0;
            explain.text = explainText[drawCnt%cnt];
            drawCnt++;
        }

        

        if (Input.GetButtonDown("Start"))
        {
            Initiate.Fade("title", Color.black, 1.0f);
        }
    }
}
