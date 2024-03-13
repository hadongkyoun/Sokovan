using UnityEngine;

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
