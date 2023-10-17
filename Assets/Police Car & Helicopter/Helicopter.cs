using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;
    private void Update()
    {        
                transform.RotateAround(_target.position, transform.up, _speed);
    }
}
