using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;

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
    public  float timeCnt;
    public gameDirector gameDirector;
    GameObject GD;

    public List<Transform> enemyCreatePositions;

    public float enemyCreateRadius = 8;

    private void Start()
    {
        GD = GameObject.Find("gameDirector");
        gameDirector = GD.GetComponent<gameDirector>();

        var positions = enemyCreatePositions
            .OrderBy(i => System.Guid.NewGuid())           // リストをシャッフル
            .Take(3)                                // 3つ取り出す
            .ToList();                              // それをリスト化

        // 各waveの半分の時間を超えたら敵が一挙出現する
        // 敵の出現の仕方は0.1秒に1体の頻度で、range～の範囲の座標に出現する
        StartCoroutine(CoEnemyCreate( 0, gameDirector.wave1 / 2, 5, positions[0]));
        StartCoroutine(CoEnemyCreate(gameDirector.wave1, gameDirector.wave2 / 2, 5, positions[1]));
        StartCoroutine(CoEnemyCreate(gameDirector.wave2 + gameDirector.wave1, gameDirector.wave3 / 2, 5, positions[2]));

    }

    IEnumerator CoEnemyCreate(float delay, float appearTime, float stopTime, Transform createPos)
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

                // createPosを中心に距離と角度を決める
                float angle = Random.Range(0f, 360f);
                float dist = Random.Range(0f, enemyCreateRadius);
                float rad = angle * Mathf.Deg2Rad;

                float x = createPos.position.x + Mathf.Cos(rad) * dist;
                float y = createPos.position.y;
                float z = createPos.position.z + Mathf.Sin(rad) * dist;

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
     
    }
}
