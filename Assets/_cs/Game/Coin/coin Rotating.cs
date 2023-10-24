using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRotating : MonoBehaviour
{
    int rotateSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        int [] i = {  180 , 250, 310 };
        int r =Random.Range(0, 3);
        rotateSpeed =i[r];
       
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, rotateSpeed,0) * Time.deltaTime,Space.World);
    }
}
