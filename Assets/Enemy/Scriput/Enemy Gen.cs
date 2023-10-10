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
    public  float timeCnt;
    private float span1;
    private float span2;
    private float span3;
    private int timing;
    public  float wave1;
    private bool judge = false;
    public gameDirector gameDirector;
    GameObject GD;

    private void Start()
    {
        GD = GameObject.Find("gameDirector");
        gameDirector = GD.GetComponent<gameDirector>();

        // 各ウェイブの半分の時間を超えたら敵が一挙出現する
        // 敵の出現の仕方は0.1秒に1体の頻度で、range～の範囲の座標に出現する
        StartCoroutine(CoEnemyCreate(0, 10, 5, rangeA, rangeB));
        StartCoroutine(CoEnemyCreate(20, 10, 5, rangeC, rangeD));
        StartCoroutine(CoEnemyCreate(40, 15, 5, rangeE, rangeF));
    }

    IEnumerator CoEnemyCreate(float delay, float appearTime, float stopTime, Transform rangeA, Transform rangeB)
    {
        yield return new WaitForSeconds(delay);
        yield return new WaitForSeconds(appearTime);

        float deltaTime = 0;
        float totalTime = 0;
        while (totalTime < stopTime)
        {
            if(deltaTime >= 0.1f)
            {
                deltaTime -= 0.1f;

                // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
                float x = Random.Range(rangeA.position.x, rangeB.position.x);
                // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
                float y = Random.Range(rangeA.position.y, rangeB.position.y);
                // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
                float z = Random.Range(rangeA.position.z, rangeB.position.z);

                // GameObjectを上記で決まったランダムな場所に生成
                Instantiate(Enemy, new Vector3(x, y, z), Enemy.transform.rotation);
            }

            yield return null;
            deltaTime += Time.deltaTime;
            totalTime += Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Enemy != null)
        {
            // 前フレームからの時間を加算していく
            time = time + Time.deltaTime;
            timeCnt = timeCnt + Time.deltaTime;
            
            if (timeCnt >= gameDirector.wave1 / 2 && this.judge == false)
            {
                this.timing = (int)(Random.Range(1, 4));
                this.judge = true;
            }
            if(timeCnt == gameDirector.wave2)
            {
                this.timing = (int)(Random.Range(1, 4));
            }
            if(timeCnt == gameDirector.wave3)
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
        */
    }
}
