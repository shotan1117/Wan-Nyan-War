using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotdisappear : MonoBehaviour
{
    int timeCnt = 10 * 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeCnt<=0)
        {
            Destroy(this.gameObject);
        }
        timeCnt--;

    }
}
