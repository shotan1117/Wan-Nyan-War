using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class EnemyGen : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject Enemy;
    [SerializeField]
    [Tooltip("生成するGameObjectボス")]
    private GameObject Boss;

    // 経過時間
    public  float timeCnt;

    private int GenerateCnt = 0;
    private int Generatenum = 3;

    public gameDirector gameDirector;
    GameObject GD;

    public List<Transform> enemyCreatePositions;

    public float enemyCreateRadius = 8;

    public GameObject canvas;

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
        //敵の生成間隔
        StartCoroutine(CoEnemyCreate( 0, gameDirector.wave1 / 2, 5, positions[0]));
        StartCoroutine(CoEnemyCreate(gameDirector.wave1, gameDirector.wave2 / 2, 5, positions[1]));
        StartCoroutine(CoEnemyCreate(gameDirector.wave2 + gameDirector.wave1, gameDirector.wave3 / 2, 5, positions[2]));
        //ボスの生成間隔
        StartCoroutine(CoBossCreate(0, gameDirector.wave1 / 2, 5, positions[0]));
        StartCoroutine(CoBossCreate(gameDirector.wave1, gameDirector.wave2 / 2, 5, positions[1]));
        StartCoroutine(CoBossCreate(gameDirector.wave2 + gameDirector.wave1, gameDirector.wave3 / 2, 5, positions[2]));

        //警告画像の初期化
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
                float y = createPos.position.y + 0.5f;
                float z = createPos.position.z + Mathf.Sin(rad) * dist;

                // GameObjectを上記で決まったランダムな場所に生成

                Instantiate(Enemy, new Vector3(x, y, z), Enemy.transform.rotation);

                if (GameObject.Find("Logo1(Clone)") == null)
                {
                    GhostArrangement("Logo1", -1500, 300);
                    GhostArrangement("Logo2", -1500, 150);
                }

            }

            yield return null;
            deltaTime += Time.deltaTime;
            totalTime += Time.deltaTime;
        }
    }

    IEnumerator CoBossCreate(float delay, float appearTime, float stopTime, Transform createPos)
    {
        yield return new WaitForSeconds(delay);
        yield return new WaitForSeconds(appearTime);
        while (Generatenum > GenerateCnt)
        {
            // createPosを中心に距離と角度を決める
            float angle = Random.Range(0f, 360f);
            float dist = Random.Range(0f, enemyCreateRadius);
            float rad = angle * Mathf.Deg2Rad;

            float x = createPos.position.x + Mathf.Cos(rad) * dist;
            float y = createPos.position.y;
            float z = createPos.position.z + Mathf.Sin(rad) * dist;

            // GameObjectを上記で決まったランダムな場所に生成
            Instantiate(Boss, new Vector3(x, y, z), Boss.transform.rotation);
            GenerateCnt++;
        }
        GenerateCnt = 0;
        yield return null;
    }


    public void GhostArrangement(string prefabs_path, float pos_x, float pos_y)
    {
        //インスタンスの生成
        GameObject ui = (GameObject)Resources.Load(prefabs_path);

        /*{ 
        //修正前
        Instantiate(ui, new Vector3(pos_x, pos_y, 0), Quaternion.identity);

        //canvasの子に指定
        ui.transform.SetParent(this.canvas.transform, false);
         }*/

        //修正後
        GameObject ui_clone = Instantiate(ui, new Vector3(pos_x, pos_y, 0), Quaternion.identity);

        //canvasの子に指定
        ui_clone.transform.SetParent(canvas.transform, false);
    }
        // Update is called once per frame
    void Update()
    {
         if(GameObject.Find("Logo1(Clone)") != null)
         {
            GameObject logo1 = GameObject.Find("Logo1(Clone)");
            if (logo1.transform.position.x <= 3000)
            {
                logo1.transform.position += new Vector3(10, 0, 0);
            }
            else
            {
                Destroy(logo1);
            }
         }
        if (GameObject.Find("Logo2(Clone)") != null)
        {
            GameObject logo2 = GameObject.Find("Logo2(Clone)");
            if (logo2.transform.position.x <= 3000)
            {
                logo2.transform.position += new Vector3(10, 0, 0);
            }
            else
            {
                Destroy(logo2);
            }
        }
    }
}
