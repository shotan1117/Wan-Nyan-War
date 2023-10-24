using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finishTEXT1 : MonoBehaviour
{
    Text text;
    float timeCnt;
    public bool finish;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        finish = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(finish)
        {
            timeCnt += Time.deltaTime;
            if (timeCnt < 0.1) { text.text = "--"; }
            else if (timeCnt < 0.2) { text.text = "-F-"; }
            else if (timeCnt < 0.3) { text.text = "-FI-"; }
            else if (timeCnt < 0.4) { text.text = "-FIN-"; }
            else if (timeCnt < 0.5) { text.text = "-FINI-"; }
            else if (timeCnt < 0.6) { text.text = "-FINIS-"; }
            else { text.text = "-FINISH-"; }
        }
        
    }
}
