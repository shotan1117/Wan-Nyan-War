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

    public int GetPlayerNo() { return (int)playerNo; }

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
           
            if(playerNo == 1)
            {
                ScoreManager.AddP1Score(1);
            }
            else if(playerNo == 2)
            {
                ScoreManager.AddP2Score(1);
            }
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Shot")
        {

            if (playerNo == 1)
            {
                ScoreManager.MinusP1Score(1);
            }
            else if (playerNo == 2)
            {
                ScoreManager.MinusP2Score(1);
            }
        }
    }
}