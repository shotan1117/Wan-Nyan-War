using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float Speed;
    [SerializeField]
    private float _radius = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(_target.position, transform.up, Speed);
    }
}
