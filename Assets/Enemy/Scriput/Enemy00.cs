using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //Player�^�O�̂��Ă���I�u�W�F�N�g��T���A�����ǂ��悤�ɂ���
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.destination = player.transform.position;
        }
    }

    // �����������ɌĂ΂��֐�
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit"); // ���O��\������
    }
}
