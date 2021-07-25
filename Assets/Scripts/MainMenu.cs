using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayTest ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //Load next level in que

    }

    public void QuitGame ()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
}
