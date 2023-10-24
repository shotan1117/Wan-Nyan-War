using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class TitleManager : MonoBehaviour
{
    public GameObject title;

    public GameObject tutorial;
    public GameObject game;   

  
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            SceneManager.LoadScene("Game");
        }
        if (Input.GetButtonDown("Back"))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }


}