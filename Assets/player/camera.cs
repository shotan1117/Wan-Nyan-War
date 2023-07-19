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
        // targetの移動量分、自分（カメラ）も移動する
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;

        rotate = Input.GetAxisRaw("direction" + playerNo);
            // targetの位置のY軸を中心に、回転（公転）する
            transform.RotateAround(targetPos, Vector3.up, -rotate * Time.deltaTime * 300f);
    }
}