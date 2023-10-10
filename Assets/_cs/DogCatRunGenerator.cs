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
    private float addtime = 0;
    private Vector3 pos;
    private Vector3 addpos;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(1000, 0, 0);
        addpos = new Vector3(0, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;
        this.addtime += Time.deltaTime;
        if (this.addtime > 1.0f)
        {
            addpos.x = (-this.addtime)*5;
        }

        if (this.time > this.span)
        {

            this.time = 0;
            int num = Random.Range(0, 3);
            switch (num)
            {
                case 0:
                    if(GameObject.Find("AngryDog(Clone)") == null)
                    {
                        GhostArrangement("AngryDog", pos.x, pos.y);
                    }
                    break;
                case 1:
                    if(GameObject.Find("RunCat1(Clone)") == null)
                    {
                        GhostArrangement("RunCat1", pos.x, pos.y);
                    }
                    break;
                case 2:
                    if(GameObject.Find("RunCat2(Clone)") == null)
                    {
                        GhostArrangement("RunCat2", pos.x, pos.y);
                    }
                    break;
            }
        }
        if (GameObject.Find("AngryDog(Clone)") != null)
        {
            GameObject.Find("AngryDog(Clone)").transform.position += addpos;
            if(GameObject.Find("AngryDog(Clone)").transform.position.x < -50)
            {
                Destroy(GameObject.Find("AngryDog(Clone)"));
                this.addtime = 0;
            }
        }
        if (GameObject.Find("RunCat1(Clone)") != null)
        {
            GameObject.Find("RunCat1(Clone)").transform.position += addpos;
            if(GameObject.Find("RunCat1(Clone)").transform.position.x < -50)
            {
                Destroy(GameObject.Find("RunCat1(Clone)"));
                this.addtime = 0;
            }
        }
        if (GameObject.Find("RunCat2(Clone)") != null)
        {
            GameObject.Find("RunCat2(Clone)").transform.position += addpos;
            if (GameObject.Find("RunCat2(Clone)").transform.position.x < -50)
            {
                Destroy(GameObject.Find("RunCat2(Clone)"));
                this.addtime = 0;
            }
        }
    }
    public void GhostArrangement(string prefabs_path, float pos_x, float pos_y)
    {
        //インスタンスの生成
        GameObject ui = Resources.Load(prefabs_path) as GameObject;
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
