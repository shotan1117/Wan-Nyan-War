using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinfly : MonoBehaviour
{
    [SerializeField]
    float CoinStopY;

    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(0, 250);
        int y= Random.Range(400, 700);
        int z = Random.Range(0, 250);
     
        GetComponent<Rigidbody>().AddForce(new Vector3(x,y, z));
        StartCoroutine(CheckPositionY());
    }

    IEnumerator CheckPositionY()
    {
        while(transform.position.y > CoinStopY)
        {
            yield return null;
        }

        var rb = GetComponent<Rigidbody>();
        Destroy(rb);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
