using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _radius = 0.6f;
    private void Update()
    {        
                transform.RotateAround(_target.position, transform.up, _speed);
    }
}
