using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyGen : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject Enemy;
    [SerializeField]
    [Tooltip("��������͈�A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("��������͈�B")]
    private Transform rangeB;
    [SerializeField]
    [Tooltip("��������͈�C")]
    private Transform rangeC;
    [SerializeField]
    [Tooltip("��������͈�D")]
    private Transform rangeD;
    [SerializeField]
    [Tooltip("��������͈�E")]
    private Transform rangeE;
    [SerializeField]
    [Tooltip("��������͈�F")]
    private Transform rangeF;

    // �o�ߎ���
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
        // �O�t���[������̎��Ԃ����Z���Ă���
        time = time + Time.deltaTime;
        timeCnt = timeCnt + Time.deltaTime;
        if(timeCnt > gameDirector.wave1 / 2.0f) 
        {
            this.timing = (int)(Random.Range(1, 4));
        }
        
        // ��0.1�b�u���Ƀ����_���ɐ��������悤�ɂ���B
        if (this.timing == 1 && this.span1 <= 5.0f)
        {
            this.span1 = span1 + Time.deltaTime;
            if (time > 0.1f)
            {
                // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float x = Random.Range(rangeA.position.x, rangeB.position.x);
                // rangeA��rangeB��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float y = Random.Range(rangeA.position.y, rangeB.position.y);
                // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float z = Random.Range(rangeA.position.z, rangeB.position.z);

                // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                Instantiate(Enemy, new Vector3(x, y, z), Enemy.transform.rotation);

                // �o�ߎ��ԃ��Z�b�g
                time = 0f;
            }
        }
        if (this.timing == 2 && this.span2 <= 5.0f)
        {
            this.span2 = span2 + Time.deltaTime;
            if (time > 0.1f)
            {
                    // rangeC��rangeD��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float x = Random.Range(rangeC.position.x, rangeD.position.x);
                    // rangeC��rangeD��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float y = Random.Range(rangeC.position.y, rangeD.position.y);
                    // rangeC��rangeD��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float z = Random.Range(rangeC.position.z, rangeD.position.z);

                    // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                    Instantiate(Enemy, new Vector3(x, y, z), Enemy.transform.rotation);

                    // �o�ߎ��ԃ��Z�b�g
                    time = 0f;
            }
        }
        if (this.timing == 3 && this.span3 <= 5.0f)
        {
            this.span3 = span3 + Time.deltaTime;
            if (time > 0.1f)
            {
                // rangeE��rangeF��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float x = Random.Range(rangeE.position.x, rangeF.position.x);
                // rangeE��rangeF��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float y = Random.Range(rangeE.position.y, rangeF.position.y);
                // rangeE��rangeF��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float z = Random.Range(rangeE.position.z, rangeF.position.z);

                // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                Instantiate(Enemy, new Vector3(x, y, z), Enemy.transform.rotation);

                // �o�ߎ��ԃ��Z�b�g
                time = 0f;
            }

        }
    }
}
