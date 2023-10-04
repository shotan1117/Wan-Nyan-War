using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogCatRunGenerator : MonoBehaviour
{
    public GameObject dogPrefab;
    public GameObject catPrefab1;
    public GameObject catPrefab2;
    private float span = 5.0f;
    private float time = 0;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        //GhostArrangement("catPrefab1", 0, 0);
        //GhostArrangement("catPrefab2", 0, 0);
        //GhostArrangement("dogPrefab", 0, 0);
    }


    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;
        if (this.time > this.span)
        {
            this.time = 0;
            int num = Random.Range(1, 11);

            if (num <= 2)
            {
                GhostArrangement("catPrefab1", 0, 0);
            }
            else if (num <= 4)
            {

                GhostArrangement("catPrefab2", 0, 0);
            }
            else
            {

                GhostArrangement("dogPrefab", 0, 0);
            }
        }
    }
    
    public void GhostArrangement(string prefabs_path, float pos_x, float pos_y)
    {
        //インスタンスの生成
        GameObject ui = (GameObject)Resources.Load(prefabs_path);

        /*{ 
        //修正前
        Instantiate(ui, new Vector3(pos_x, pos_y, 0), Quaternion.identity);

        //canvasの子に指定
        ui.transform.SetParent(this.canvas.transform, false);
         }*/

        //修正後
        GameObject ui_clone = Instantiate(ui, new Vector3(pos_x, pos_y, 0), Quaternion.identity);

        //canvasの子に指定
        ui_clone.transform.SetParent(canvas.transform, false);
    }
}
