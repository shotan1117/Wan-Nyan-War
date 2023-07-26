using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorTutorial : MonoBehaviour
{
    public GameObject DogPBR;
    private float span = 6.0f;
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
                this.span = 4.5f;
            }
            else if (this.timeCnt > 60)
            {
                this.span = 2.0f;
            }
            if (this.delta > this.span)
            {
                this.delta = 0;
                float x = Random.Range(-6.0f, 12.0f);
                float z = Random.Range(-16.0f, -19.0f);
                Instantiate(DogPBR, new Vector3(x, 0.5f, z), DogPBR.transform.rotation);
            }
        }
    }
}

