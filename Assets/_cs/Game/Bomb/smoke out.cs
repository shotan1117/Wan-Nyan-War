using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeout : MonoBehaviour
{
    public GameObject vfx_smoke;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(vfx_smoke, this.transform.position,Quaternion.identity);
    }
}
