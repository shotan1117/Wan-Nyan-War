using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class player1 : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    int playerNo;
    public GameObject cameraMan;
    Vector2 move;
    Rigidbody rb;
    // �O����\���x�N�g����ʓr�p�ӂ���
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        move.x = Input.GetAxis("Horizontal" + playerNo);
        move.y = Input.GetAxis("Vertical" + playerNo);
    }
    void FixedUpdate()
    {
        // �J�����̕�������AX-Z���ʂ̒P�ʃx�N�g�����擾
        Vector3 cameraForward = Vector3.Scale(cameraMan.transform.forward, new Vector3(1, 0, 1)).normalized;

        // �����L�[�̓��͒l�ƃJ�����̌�������A�ړ�����������
        Vector3 moveForward = cameraForward * move.y + cameraMan.transform.right * move.x;
        rb.velocity = moveForward * speed + new Vector3(0, rb.velocity.y, 0);
        // �L�����N�^�[�̌�����i�s������
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }
    }
}