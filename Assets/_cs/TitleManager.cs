using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class TitleManager : MonoBehaviour
{
    Button button;
    public GameObject title;

    public GameObject tutorial;
    public GameObject game;

    private double time_;
   
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        time_ += Time.deltaTime;



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