using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    int playerNo;
    public GameObject cameraMan;
    Vector2 move;
    Rigidbody rb;
    private Vector3 moveForward;
    public Vector3 MoveForward
    {
        get { return moveForward; }
    }
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
        Vector3 cameraForward = Vector3.Scale(cameraMan.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        moveForward = cameraForward * move.y + cameraMan.transform.right * move.x;
        rb.velocity = moveForward * speed + new Vector3(0, rb.velocity.y, 0);
        // キャラクターの向きを進行方向に
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }
    }
}