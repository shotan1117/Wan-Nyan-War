using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;

public class EnemyGen : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject Enemy;
    [SerializeField]
    [Tooltip("��������GameObject�{�X")]
    private GameObject Boss;
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
    public  float timeCnt;

    private int GenerateCnt = 0;
    private int Generatenum = 3;

    public gameDirector gameDirector;
    GameObject GD;

    public List<Transform> enemyCreatePositions;

    public float enemyCreateRadius = 8;

    private void Start()
    {
        GD = GameObject.Find("gameDirector");
        gameDirector = GD.GetComponent<gameDirector>();

        var positions = enemyCreatePositions
            .OrderBy(i => System.Guid.NewGuid())           // ���X�g���V���b�t��
            .Take(3)                                // 3���o��
            .ToList();                              // ��������X�g��

        // �ewave�̔����̎��Ԃ𒴂�����G���ꋓ�o������
        // �G�̏o���̎d����0.1�b��1�̂̕p�x�ŁArange�`�͈̔͂̍��W�ɏo������
        //�G�̐����Ԋu
        StartCoroutine(CoEnemyCreate( 0, gameDirector.wave1 / 2, 5, positions[0]));
        StartCoroutine(CoEnemyCreate(gameDirector.wave1, gameDirector.wave2 / 2, 5, positions[1]));
        StartCoroutine(CoEnemyCreate(gameDirector.wave2 + gameDirector.wave1, gameDirector.wave3 / 2, 5, positions[2]));
        //�{�X�̐����Ԋu
        StartCoroutine(CoBossCreate(0, gameDirector.wave1 / 2, 5, positions[0]));
        StartCoroutine(CoBossCreate(gameDirector.wave1, gameDirector.wave2 / 2, 5, positions[1]));
        StartCoroutine(CoBossCreate(gameDirector.wave2 + gameDirector.wave1, gameDirector.wave3 / 2, 5, positions[2]));
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

                // createPos�𒆐S�ɋ����Ɗp�x�����߂�
                float angle = Random.Range(0f, 360f);
                float dist = Random.Range(0f, enemyCreateRadius);
                float rad = angle * Mathf.Deg2Rad;

                float x = createPos.position.x + Mathf.Cos(rad) * dist;
                float y = createPos.position.y + 0.5f;
                float z = createPos.position.z + Mathf.Sin(rad) * dist;

                // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                Instantiate(Enemy, new Vector3(x, y, z), Enemy.transform.rotation);
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
            // createPos�𒆐S�ɋ����Ɗp�x�����߂�
            float angle = Random.Range(0f, 360f);
            float dist = Random.Range(0f, enemyCreateRadius);
            float rad = angle * Mathf.Deg2Rad;

            float x = createPos.position.x + Mathf.Cos(rad) * dist;
            float y = createPos.position.y;
            float z = createPos.position.z + Mathf.Sin(rad) * dist;

            // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
            Instantiate(Boss, new Vector3(x, y, z), Boss.transform.rotation);
            GenerateCnt++;
        }
        yield return null;
    }
    

    // Update is called once per frame
    void Update()
    {
     
    }
}
