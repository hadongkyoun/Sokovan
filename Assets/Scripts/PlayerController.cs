using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody rb;
    private float xInput;
    private float zInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        CheckInput();

        Movement();
    }

    void CheckInput()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    
    void Movement()
    {
        rb.velocity = new Vector3(xInput * speed, rb.velocity.y, zInput * speed);
    }
}
