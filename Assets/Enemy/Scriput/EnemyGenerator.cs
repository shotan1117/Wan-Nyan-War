using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject DogPBR;
    private float span = 4.0f;
    private float delta = 0;
    private float timeCnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DogPBR != null)
        {
            this.delta += Time.deltaTime;
            this.timeCnt += Time.deltaTime;
                      
            if (this.timeCnt > 30)
            {
                this.span = 2.0f;
            }
            else if (this.timeCnt > 60)
            {
                this.span = 1.0f;
            }
            if (this.delta > this.span)
            {
                this.delta = 0;
                float x = Random.Range(2.0f, 8.0f);
                float z = Random.Range(-14.5f, -16.5f);
                Instantiate(DogPBR, new Vector3(x, 0.5f, z), DogPBR.transform.rotation);
                float x1 = Random.Range(6.0f, 10.0f);
                float z1 = Random.Range(1.0f, 9.0f);
                Instantiate(DogPBR, new Vector3(x1, 0.5f, z1), DogPBR.transform.rotation);
                float x2 = Random.Range(6.0f, 10.0f);
                float z2 = Random.Range(1.0f, 9.0f);
                Instantiate(DogPBR, new Vector3(x1, 0.5f, z1), DogPBR.transform.rotation);
                if (this.timeCnt > 60)
                {
                    float x3 = Random.Range(-4.0f, 2.0f);
                    float z3 = Random.Range(-8.0f, 1.0f);
                    Instantiate(DogPBR, new Vector3(x3, 0.5f, z3), DogPBR.transform.rotation);
                }
            }
        }
    }
}
