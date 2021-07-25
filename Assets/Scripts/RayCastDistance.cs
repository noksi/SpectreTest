using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastDistance : RayCastSelect
{
    //Color oldColor;

    //public Color selectionColor;

    public float rotation = 0f;

    protected override void OnRayCastEnter(GameObject target)
    {
        transform.Rotate(Vector3.up, Time.deltaTime * 0);
        //transform.Rotate(new Vector3(0f, 0f, rotation));
        //oldColor = target.GetComponent<Renderer>().material.GetColor("Color");
        //target.GetComponent<Renderer>().material.SetColor("_Color", selectionColor);
    }

    protected override void OnRayCastLeave(GameObject target)
    {
        transform.Rotate(Vector3.up, Time.deltaTime * 30);
        //target.GetComponent<Renderer>().material.SetColor("_Color", oldColor);
    }
}
