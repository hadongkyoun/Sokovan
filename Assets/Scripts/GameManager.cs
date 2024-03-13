using UnityEngine;

public class GameManager : MonoBehaviour
{

    public ItemBox[] itemBoxes;

    public bool isGameOver;

    void Start()
    {
        isGameOver = false;
    }

    void Update()
    {
        int count = 0;

        for(int i=0; i<3; i++)
        {
           if(itemBoxes[i].isOveraped == true)
            {
                count++;
            }
            
        }
        
        if(count >= 3)
        {
            Debug.Log("°ÔÀÓ ½Â¸®");
            isGameOver = true;
        }
    }
}
