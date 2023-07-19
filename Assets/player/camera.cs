using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class camera : MonoBehaviour
{
  public  GameObject targetObj;
    Vector3 targetPos;
    [SerializeField]
    int playerNo = 1;
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

        rotate = Input.GetAxisRaw("direction" + playerNo);
            // target�̈ʒu��Y���𒆐S�ɁA��]�i���]�j����
            transform.RotateAround(targetPos, Vector3.up, -rotate * Time.deltaTime * 300f);
    }
}