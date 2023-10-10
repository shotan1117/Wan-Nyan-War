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

        // �e�E�F�C�u�̔����̎��Ԃ𒴂�����G���ꋓ�o������
        // �G�̏o���̎d����0.1�b��1�̂̕p�x�ŁArange�`�͈̔͂̍��W�ɏo������
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

                // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float x = Random.Range(rangeA.position.x, rangeB.position.x);
                // rangeA��rangeB��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float y = Random.Range(rangeA.position.y, rangeB.position.y);
                // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float z = Random.Range(rangeA.position.z, rangeB.position.z);

                // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
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
            // �O�t���[������̎��Ԃ����Z���Ă���
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
        */
    }
}
