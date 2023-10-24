using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    AudioSource audioo;
    public AudioClip bgm1;
    public AudioClip bgm2;
    bool bgmChange;
    bool bgmChanged;
   
    // Start is called before the first frame update
    void Start()
    {
        bgmChange = false;
        bgmChanged = false;

        audioo = GetComponent<AudioSource>();
        audioo.clip = bgm1;
        audioo.Play();

        Debug.Log("bgm start");
    }

    // Update is called once per frame
    void Update()
    {
       
        if (bgmChange&&!bgmChanged)
        {
            audioo.Stop();
            audioo.clip = bgm2;
            audioo.Play();
            bgmChange = false;
            bgmChanged = true;

            Debug.Log("bgm change");
        }
        if (gameDirector.waveCnt == 3 )
        {
            bgmChange = true;
        }

        
    }
}
