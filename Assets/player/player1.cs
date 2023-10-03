using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class player1 : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float playerNo;

    [SerializeField]
    private float playersiderotate;

    public GameObject cam;
    Quaternion cameraRot, characterRot;
    private Rigidbody rb;
    private Vector2 move;

    //変数の宣言(角度の制限用)
    float minX = -90f, maxX = 90f;

    void Start()
    {
        cameraRot = cam.transform.localRotation;
        characterRot = transform.localRotation;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xRot = Input.GetAxis("direction" + playerNo) * playersiderotate;
        //縦方向の視点変更は遅く
        //float yRot = Input.GetAxis("directions" + playerNO) * playersiderotate * 0.5f;
        move.x = Input.GetAxis("Horizontal" + playerNo) * speed;
        move.y = Input.GetAxis("Vertical" + playerNo) * speed;

        // cameraRot *= Quaternion.Euler(-yRot, 0, 0);
        characterRot *= Quaternion.Euler(0, xRot, 0);

        //Updateの中で作成した関数を呼ぶ
        //cameraRot = ClampRotation(cameraRot);
        //cam.transform.localRotation = cameraRot;
        transform.localRotation = characterRot;
    }

    private void FixedUpdate()
    {
        rb.velocity = (transform.right * move.x) + (transform.forward * move.y) + new Vector3(0, rb.velocity.y, 0);
    }

    //角度制限関数の作成
    private Quaternion ClampRotation(Quaternion q)
    {
        //q = x,y,z,w (x,y,zはベクトル（量と向き）：wはスカラー（座標とは無関係の量）)
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        float angleX = Mathf.Atan(q.x) * Mathf.Rad2Deg * 2f;

        angleX = Mathf.Clamp(angleX, minX, maxX);

        q.x = Mathf.Tan(angleX * Mathf.Deg2Rad * 0.5f);

        return q;
    }
}