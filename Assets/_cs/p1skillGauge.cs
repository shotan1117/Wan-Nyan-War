using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1skillGauge : MonoBehaviour
{
    UnityEngine.UI.Slider p1Skill;

  
     public GameObject player1;

    float gauge;
    // Start is called before the first frame update
    void Start()
    {
        p1Skill = GetComponent<Slider>();
        
    }

    // Update is called once per frame
    void Update()
    {

        this.gameObject.GetComponent<Slider>().value = player1.GetComponent<playerShot>().bomTime;


        //gauge = player1.GetComponent<playerShot>().bomTime;
        //print(gauge);

    }
}
