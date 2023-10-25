using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSE : MonoBehaviour
{
    AudioSource ass;
    public AudioClip acc;
    // Start is called before the first frame update
    void Start()
    {
        
        ass = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.tag=="Coin")
        {
            ass.PlayOneShot(acc);
        }
            
       
    }
}
