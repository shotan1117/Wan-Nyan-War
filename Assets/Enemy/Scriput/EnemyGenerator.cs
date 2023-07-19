using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject DogPBR;
    private float span = 0;
    private float delta = 0;
    private int timeCnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.timeCnt++;
        this.delta += Time.deltaTime;
        if (this.timeCnt < 500)
        {
            this.span = 3.0f;
        }
        else if (this.timeCnt >= 1500)
        {
            this.span = 1.5f;
        }
        if (this.delta > this.span)
        {
            this.delta = 0;
            float x = Random.Range(-25.0f, 25.0f);
            float z = Random.Range(-25.0f, 25.0f);

            Instantiate(DogPBR, new Vector3(x, 0.1f, z), DogPBR.transform.rotation);
        }
    }
}
