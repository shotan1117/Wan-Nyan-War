using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject DogPBR;
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            float x = Random.Range(-25.0f, 25.0f);
            float z = Random.Range(-25.0f, 25.0f);

            Instantiate(DogPBR, new Vector3(x, 2.0f, z), DogPBR.transform.rotation);
        }
    }
}
