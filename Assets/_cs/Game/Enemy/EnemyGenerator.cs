using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject DogPBR;
    private float span = 4.0f;
    private float delta = 0;
    private float timeCnt = 0;

    [SerializeField]
    [Tooltip("¶¬‚·‚éGameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("¶¬‚·‚é”ÍˆÍA")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("¶¬‚·‚é”ÍˆÍB")]
    private Transform rangeB;
    [SerializeField]
    [Tooltip("¶¬‚·‚é”ÍˆÍC")]
    private Transform rangeC;
    [SerializeField]
    [Tooltip("¶¬‚·‚é”ÍˆÍD")]
    private Transform rangeD;


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
           
            if (this.delta > this.span)
            {
                this.delta = 0;
                float x = Random.Range(-10.0f, 0.0f);
                float z = Random.Range(-32.0f, -35.5f);
                Instantiate(DogPBR, new Vector3(x, 0.5f, z), DogPBR.transform.rotation);
                float x1 = Random.Range(53.0f, 63.0f);
                float z1 = Random.Range(15.0f, 18.5f);
                Instantiate(DogPBR, new Vector3(x1, 0.5f, z1), DogPBR.transform.rotation);
                float x2 = Random.Range(-25.0f, 89.0f);
                float z2 = Random.Range(-3.4f, -10.0f);
                Instantiate(DogPBR, new Vector3(x2, 0.5f, z2), DogPBR.transform.rotation);
               
            }
        }
    }
}
