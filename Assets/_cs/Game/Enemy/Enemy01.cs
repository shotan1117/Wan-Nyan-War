using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01 : MonoBehaviour
{
    private float chargeTime = 5.0f;
    private float timeCount;
    private float Enemyspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Enemyspeed = Random.Range(1.0f, 5.0f);
        timeCount += Time.deltaTime;

        // 自動前進
        transform.position += transform.forward * Time.deltaTime * 2.0f;

        // 指定時間の経過（条件）
        if (timeCount > chargeTime)
        {
            // 進路をランダムに変更する
            Vector3 course = new Vector3(0, Random.Range(0, 180), 0);
            transform.localRotation = Quaternion.Euler(course);

            // タイムカウントを０に戻す
            timeCount = 0;
        }
    }
}

