using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Sprite;
//using UnityEngine.SpriteRenderer;

public class EndingManager : MonoBehaviour
{
    Image image;
    public Sprite[] sprites = new Sprite[2];

    int winnerPlayer = 0;
    // Start is called before the first frame update
    void Start()
    {
        image = GameObject.Find("Image").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { this.winnerPlayer = (winnerPlayer + 1) % 2; }
        if (this.winnerPlayer == 0) { image.sprite = sprites[0]; }
        else { image.sprite = sprites[1]; }
    }

   
}
