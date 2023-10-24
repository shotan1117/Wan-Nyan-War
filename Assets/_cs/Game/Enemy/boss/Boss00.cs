using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boss00 : MonoBehaviour
{
    GameObject player;
    private float speed = 5.0f;
    private GameObject[] targets;
    private bool isSwitch = false;
    private GameObject closePlayer;
    // Start is called before the first frame update
    void Start()
    {

        // タグを使って画面上の全ての敵の情報を取得
        targets = GameObject.FindGameObjectsWithTag("Player");

        // 「初期値」の設定
        float closeDist = 1000;

        foreach (GameObject target in targets)
        {
            //このオブジェクト（Enemy）とプレイヤまでの距離を計測
            float tDist = Vector3.Distance(transform.position, target.transform.position);

            //もしも「初期位置」よりも「計測した敵までの距離」のほうが近いならば
            if (closeDist > tDist)
            {
                // 「closeDist」を「tDist（その敵までの距離）」に置き換える。
                // これを繰り返すことで、一番近い敵を見つけ出すことができる。
                closeDist = tDist;

                // 一番近い敵の情報をclosePlayerという変数に格納する（★）
                closePlayer = target;
            }
        }
        //0.5秒後に、一番近いプレイヤに向かって移動を開始する
        Invoke("SwitchOn", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

        if (isSwitch)
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            if (agent != null)
            {
                float step = speed * Time.deltaTime;

                // ★で得られたcloseEnemyを目的地として設定する。
                transform.position = Vector3.MoveTowards(transform.position, closePlayer.transform.position, step);
                transform.LookAt(closePlayer.transform.position);
                agent.destination = transform.position;
            }
        }

    }
    void SwitchOn()
    {
        isSwitch = true;
    }
}
