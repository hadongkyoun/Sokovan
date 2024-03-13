using UnityEngine;

public class ItemBox : MonoBehaviour
{
    // 엔드 포인트 접촉 여부
    public bool isOveraped = false;

    // 엔드 포인트와 접촉 시 사용할 컬러
    [SerializeField] private Color touchColor;
    private Renderer myRenderer;
    private Color originColor;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originColor = myRenderer.material.color;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {   
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originColor;
        }
    }
}
