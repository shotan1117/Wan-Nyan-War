using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class camera : MonoBehaviour
{
  public  GameObject targetObj;
    Vector3 targetPos;
    [SerializeField]
    int playerNo;
    float rotate;

    void Start()
    {
        targetPos = targetObj.transform.position;
    }

    void Update()
    {
        // target�̈ړ��ʕ��A�����i�J�����j���ړ�����
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;

            // �}�E�X�̈ړ���
            rotate = Input.GetAxisRaw("direction" + playerNo);
            // target�̈ʒu��Y���𒆐S�ɁA��]�i���]�j����
            transform.RotateAround(targetPos, Vector3.up, -rotate * Time.deltaTime * 300f);
            // �J�����̐����ړ��i���p�x�����Ȃ��A�K�v��������΃R�����g�A�E�g�j
           // transform.RotateAround(targetPos, transform.right, mouseInputY * Time.deltaTime * 200f);
    }
}