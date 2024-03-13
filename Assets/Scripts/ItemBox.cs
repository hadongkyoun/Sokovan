using UnityEngine;

public class ItemBox : MonoBehaviour
{
    // ���� ����Ʈ ���� ����
    public bool isOveraped = false;

    // ���� ����Ʈ�� ���� �� ����� �÷�
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
