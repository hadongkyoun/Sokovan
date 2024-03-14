using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;

    [SerializeField] private float speed = 3f;
    private Rigidbody rb;
    private float xInput;
    private float zInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        if (gameManager.isGameOver == true)
            return;

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
