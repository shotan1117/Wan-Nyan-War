using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class player1 : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float playerNo;

    [SerializeField]
    private float playersiderotate;

    public GameObject cam;
    Quaternion characterRot;
    private Rigidbody rb;
    private Vector2 move;

    void Start()
    {
        characterRot = transform.localRotation;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xRot = Input.GetAxis("direction" + playerNo) * playersiderotate;
        move.x = Input.GetAxis("Horizontal" + playerNo) * speed;
        move.y = Input.GetAxis("Vertical" + playerNo) * speed;

        characterRot *= Quaternion.Euler(0, xRot, 0);
        transform.localRotation = characterRot;
    }

    private void FixedUpdate()
    {
        rb.velocity = (transform.right * move.x) + (transform.forward * move.y) + new Vector3(0, rb.velocity.y, 0);
    }
}