using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject winUI;
    public ItemBox[] itemBoxes;

    public bool isGameOver;

    float timer = 0;

    void Start()
    {
        isGameOver = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }

        if (isGameOver == true)
            return;
        
        int count = 0;

        for(int i=0; i<3; i++)
        {
            if (itemBoxes[i].isOveraped == true)
            {
                count++;
            }
            else
                // 하나라도 없으면 더이상 돌 이유 X
                break;
        }
        
        if(count > 2)
        {
            Debug.Log("게임 승리!");
            isGameOver = true;
            winUI.SetActive(true);
        }
    }
}
