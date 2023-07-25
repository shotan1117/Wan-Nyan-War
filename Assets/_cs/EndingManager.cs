using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    Image image;
    public Sprite[] sprites = new Sprite[3];
   
   

    void Start()
    {
        GameObject Result = GameObject.Find("ResultManager");
        image = GameObject.Find("Image").GetComponent<Image>();
    }

    void Update()
    {
        switch(ResultManager.resultState)
        {
            case ResultManager.ResultState.Player1:
                image.sprite = sprites[0];
                break;
            case ResultManager.ResultState.Player2:
                image.sprite = sprites[1];
                break;
            case ResultManager.ResultState.Draw:
                image.sprite = sprites[2];
                break;
        }
       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Title");
        }
       
    }

   
}
