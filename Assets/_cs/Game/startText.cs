using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startText : MonoBehaviour
{
    Text text;
    float timeCnt;
    public bool start;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        start = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            timeCnt += Time.deltaTime;
            if (timeCnt < 0.1) { text.text = ""; }
            else if (timeCnt < 0.3) { text.text = "-S-"; }
            else if (timeCnt < 0.5) { text.text = "-ST-"; }
            else if (timeCnt < 0.7) { text.text = "-STA-"; }
            else if (timeCnt < 0.9) { text.text = "-STAR-"; }
            else if (timeCnt < 5.0) { text.text = "-START-"; }
            else { text.text = "";
                start = false;
            }
        }

    }
}
