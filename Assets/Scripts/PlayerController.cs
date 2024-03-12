using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 100, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, speed);
        }

        if(Input.GetKey(KeyCode.S)) 
        { 
            rb.AddForce(0, 0, -speed);
        }

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed, 0, 0);
        }

        if(Input.GetKey (KeyCode.D))
        {
            rb.AddForce(speed, 0, 0);
        }
        
    }
}
