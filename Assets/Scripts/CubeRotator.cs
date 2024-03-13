using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeRotator : MonoBehaviour
{
    private float speed = 40f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
    }

}
