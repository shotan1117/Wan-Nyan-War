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
        if (DogPBR != null)
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
                float x = Random.Range(-6.0f, 12.0f);
                float z = Random.Range(-16.0f, -19.0f);
                Instantiate(DogPBR, new Vector3(x, 0.5f, z), DogPBR.transform.rotation);
                float x1 = Random.Range(6.0f, 10.0f);
                float z1 = Random.Range(1.0f, 9.0f);
                Instantiate(DogPBR, new Vector3(x1, 0.5f, z1), DogPBR.transform.rotation);
            }
        }
    }
}
