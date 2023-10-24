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

        // �����O�i
        transform.position += transform.forward * Time.deltaTime * 2.0f;

        // �w�莞�Ԃ̌o�߁i�����j
        if (timeCount > chargeTime)
        {
            // �i�H�������_���ɕύX����
            Vector3 course = new Vector3(0, Random.Range(0, 180), 0);
            transform.localRotation = Quaternion.Euler(course);

            // �^�C���J�E���g���O�ɖ߂�
            timeCount = 0;
        }
    }
}

