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
        //Playerタグのついているオブジェクトを探し、それを追うようにする
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

    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit"); // ログを表示する
    }
}
