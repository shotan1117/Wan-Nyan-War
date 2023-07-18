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
    Vector2 move;
    float rotate;
    Rigidbody rb;
    public float angleSpeed;
    // 前方を表すベクトルを別途用意する
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
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * move.y + Camera.main.transform.right * move.x;
        rb.velocity = moveForward * speed + new Vector3(0, rb.velocity.y, 0);
        // キャラクターの向きを進行方向に
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }
    }
}