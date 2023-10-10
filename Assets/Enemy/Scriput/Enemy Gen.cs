using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyGen : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject Enemy;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;
    [SerializeField]
    [Tooltip("生成する範囲C")]
    private Transform rangeC;
    [SerializeField]
    [Tooltip("生成する範囲D")]
    private Transform rangeD;
    [SerializeField]
    [Tooltip("生成する範囲E")]
    private Transform rangeE;
    [SerializeField]
    [Tooltip("生成する範囲F")]
    private Transform rangeF;

    // 経過時間
    private float time;
    private float timeCnt;
    private float span1;
    private float span2;
    private float span3;
    private int timing;

    gameDirector gameDirector;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // 前フレームからの時間を加算していく
        time = time + Time.deltaTime;
        timeCnt = timeCnt + Time.deltaTime;
        if(timeCnt > gameDirector.wave1 / 2.0f) 
        {
            this.timing = (int)(Random.Range(1, 4));
        }
        
        // 約0.1秒置きにランダムに生成されるようにする。
        if (this.timing == 1 && this.span1 <= 5.0f)
        {
            this.span1 = span1 + Time.deltaTime;
            if (time > 0.1f)
            {
                // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                float x = Random.Range(rangeA.position.x, rangeB.position.x);
                // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
                float y = Random.Range(rangeA.position.y, rangeB.position.y);
                // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                float z = Random.Range(rangeA.position.z, rangeB.position.z);

                // GameObjectを上記で決まったランダムな場所に生成
                Instantiate(Enemy, new Vector3(x, y, z), Enemy.transform.rotation);

                // 経過時間リセット
                time = 0f;
            }
        }
        if (this.timing == 2 && this.span2 <= 5.0f)
        {
            this.span2 = span2 + Time.deltaTime;
            if (time > 0.1f)
            {
                    // rangeCとrangeDのx座標の範囲内でランダムな数値を作成
                    float x = Random.Range(rangeC.position.x, rangeD.position.x);
                    // rangeCとrangeDのy座標の範囲内でランダムな数値を作成
                    float y = Random.Range(rangeC.position.y, rangeD.position.y);
                    // rangeCとrangeDのz座標の範囲内でランダムな数値を作成
                    float z = Random.Range(rangeC.position.z, rangeD.position.z);

                    // GameObjectを上記で決まったランダムな場所に生成
                    Instantiate(Enemy, new Vector3(x, y, z), Enemy.transform.rotation);

                    // 経過時間リセット
                    time = 0f;
            }
        }
        if (this.timing == 3 && this.span3 <= 5.0f)
        {
            this.span3 = span3 + Time.deltaTime;
            if (time > 0.1f)
            {
                // rangeEとrangeFのx座標の範囲内でランダムな数値を作成
                float x = Random.Range(rangeE.position.x, rangeF.position.x);
                // rangeEとrangeFのy座標の範囲内でランダムな数値を作成
                float y = Random.Range(rangeE.position.y, rangeF.position.y);
                // rangeEとrangeFのz座標の範囲内でランダムな数値を作成
                float z = Random.Range(rangeE.position.z, rangeF.position.z);

                // GameObjectを上記で決まったランダムな場所に生成
                Instantiate(Enemy, new Vector3(x, y, z), Enemy.transform.rotation);

                // 経過時間リセット
                time = 0f;
            }

        }
    }
}
