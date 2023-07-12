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
    // Start is called before the first frame update
    void Start()
    {
       button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonDown_tutorial ()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void OnButtonDown_Game () 
    {
        SceneManager.LoadScene("Game");
    }
}
