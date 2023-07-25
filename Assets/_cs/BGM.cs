using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    AudioSource audioo;
    public AudioClip bgm1;
    public AudioClip bgm2;
    bool bgmChange=false;
    bool bgmChanged = false;
   
    // Start is called before the first frame update
    void Start()
    {
        audioo = GetComponent<AudioSource>();
        audioo.clip = bgm1;
        audioo.Play();
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
        }
        if (gameDirector.waveCnt == 3 )
        {
            bgmChange = true;
        }

        
    }
}
