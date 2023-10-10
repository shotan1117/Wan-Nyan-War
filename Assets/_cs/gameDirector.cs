using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameDirector : MonoBehaviour
{
  
    public float wave1 = 20;
    public float wave2 = 20;
    public float wave3 = 30;
   
   public static float timeCnt;
    public static int waveCnt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wave1-=Time.deltaTime;
        timeCnt=wave1;
        waveCnt = 1;
        if(wave1 <= 0)
        {
            wave1 = 0;
            wave2-= Time.deltaTime;
            timeCnt=wave2;
            waveCnt = 2;
        }
        if(wave2 <= 0)
        {
            wave2 = 0;
            wave3-= Time.deltaTime;
            timeCnt=wave3;
            waveCnt = 3;
        }

        if(wave3 <= 0)
        {
            wave3 = 0; 
            finishTEXT1.finish = true;

            Invoke("ToResult", 3f);
        }
    }

    private void ToResult ()
    {
        SceneManager.LoadScene("Result");
    }
}
