using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentCube : MonoBehaviour
{
    public GameObject ObjectToDisable;
    public GameObject TheObject;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "TransparentCube")
        {
            ObjectToDisable.SetActive(false);
            Debug.Log("Collision is true");
            FindObjectOfType<GameManager>().MainMenu();
        }
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "TransparentCube")
        {
            ObjectToDisable.SetActive(true);
            Debug.Log("Exit Collision");
        }
    }
}
