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
        // targetの移動量分、自分（カメラ）も移動する
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;

            // マウスの移動量
            rotate = Input.GetAxisRaw("direction" + playerNo);
            // targetの位置のY軸を中心に、回転（公転）する
            transform.RotateAround(targetPos, Vector3.up, -rotate * Time.deltaTime * 300f);
            // カメラの垂直移動（※角度制限なし、必要が無ければコメントアウト）
           // transform.RotateAround(targetPos, transform.right, mouseInputY * Time.deltaTime * 200f);
    }
}