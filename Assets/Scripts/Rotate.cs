using UnityEngine;

public class Rotate : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * 30);
        //transform.Rotate(new Vector3(0, 0, rotation));


    }
}