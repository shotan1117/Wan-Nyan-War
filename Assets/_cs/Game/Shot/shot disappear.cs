using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotdisappear : MonoBehaviour
{
    [SerializeField]
    float delay = 5;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, delay);
    }
}
