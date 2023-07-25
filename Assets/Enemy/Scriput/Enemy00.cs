using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    GameObject player;
    private float speed = 2.0f;
    private GameObject[] targets;
    private bool isSwitch = false;
    private GameObject closePlayer;
    // Start is called before the first frame update
    void Start()
    { 

        // �^�O���g���ĉ�ʏ�̑S�Ă̓G�̏����擾
        targets = GameObject.FindGameObjectsWithTag("Player");

        // �u�����l�v�̐ݒ�
        float closeDist = 1000;

        foreach (GameObject target in targets)
        {
            

            //���̃I�u�W�F�N�g�iEnemy�j�ƃv���C���܂ł̋������v��
            float tDist = Vector3.Distance(transform.position, target.transform.position);

            //�������u�����ʒu�v�����u�v�������G�܂ł̋����v�̂ق����߂��Ȃ��
            if(closeDist > tDist )
            {
                // �ucloseDist�v���utDist�i���̓G�܂ł̋����j�v�ɒu��������B
                // ������J��Ԃ����ƂŁA��ԋ߂��G�������o�����Ƃ��ł���B
                closeDist = tDist;

                // ��ԋ߂��G�̏���closePlayer�Ƃ����ϐ��Ɋi�[����i���j
                closePlayer = target;
            }
        }
        //0.5�b��ɁA��ԋ߂��v���C���Ɍ������Ĉړ����J�n����
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

                // ���œ���ꂽcloseEnemy��ړI�n�Ƃ��Đݒ肷��B
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
