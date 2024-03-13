using UnityEngine;

public class GameManager : MonoBehaviour
{

    public ItemBox[] itemBoxes;

    public bool isGameOver;

    float timer = 0;

    void Start()
    {
        isGameOver = false;
    }

    void Update()
    {
        if (isGameOver == true)
            return;
        
        int count = 0;

        for(int i=0; i<3; i++)
        {
           if(itemBoxes[i].isOveraped == true)
            {
                count++;
            }
        }
        
        if(count > 2)
        {
            isGameOver = true;
        }
    }
}
