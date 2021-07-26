using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableCube : MonoBehaviour
{
    public Camera Cam;
    public Transform TransformCube;
    //Collider floorcollider;
    RaycastHit hit;
    Ray ray;

    void Start()
    {
        //Cam = GameObject.Find("MainCamera").GetComponent<Camera>();
        //floorcollider = GameObject.Find("Floor").GetComponent<Collider>();
    }

    void Update()
    {
        //transform.position = Cam.ScreenWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));
        if (Input.GetMouseButton(0))
        {
            ray = Cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                //if (hit.collider == floorcollider)        //ulazi u floor collider iako nije toliko bitno, bitno da izadje iz njega
                transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * 10);
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }
        }
        //Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;

        //if (Physics.Raycast(ray, out hit))
        //{
        //    Vector3 mousePos = hit.point;

        //    Vector3 dir = hit.point - transform.position;
        //    dir.y = 0;

        //    float speed = 0.1f;
        //    if (dir.magnitude > speed)
        //    {
        //        dir.Normalize();
        //        transform.Translate(dir * speed);
        //    }

        //    Vector3 spherePos = transform.position;
        //    spherePos.y = 0;
        //}

        //Ray ray;
        //RaycastHit hit;
        //ray = Cam.ScreenPointToRay(Input.mousePosition);
        //if (Physics.Raycast(ray, out hit, 10.0f))
        //{
        //    TransformCube.transform.position = hit.point;
        //}
    }
}
