using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TransparentCube"))
        {
            SceneManager.LoadScene("Menu");
        }


    }

}