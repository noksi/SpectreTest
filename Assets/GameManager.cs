using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool CallMainMenu = false;

    public float restartDelay = 1;

   public void MainMenu()
    {
        if(CallMainMenu == false)
        {
            CallMainMenu = true;
            Debug.Log("GoToMainMenu");
            Invoke("MainMenu", restartDelay);
        }
        
        void MainMenu()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
