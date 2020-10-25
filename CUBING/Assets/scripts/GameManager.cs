using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GamehadEnded=false;
    public float RestartDelay=1f;
    public GameObject completelevelUI;  
    public void completeLevel()
    {
        completelevelUI.SetActive(true);
    }  
    public void EndGame ()
    {
        if(GamehadEnded == false)
            {
                GamehadEnded = true;
                Debug.Log("Game Over!!");  
                Invoke("restart",RestartDelay);  
            }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  
}
