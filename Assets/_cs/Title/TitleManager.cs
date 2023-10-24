using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEditor;

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
            Initiate.Fade("Game", Color.black, 1.0f);
        }
        if (Input.GetButtonDown("Back"))
        {
            Initiate.Fade("tutorial", Color.black, 1.0f);
        }
    }


}