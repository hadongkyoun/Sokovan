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
        // ���� ���� -1 ~ +1 ��
        // Horizontal => ���� ���⿡ �����Ǵ� Ű�� ����. (<-, ->, A, D)
        float inputX = Input.GetAxis("Horizontal");
        
    }
}
