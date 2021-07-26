using UnityEngine;

public class RayCastSelect : MonoBehaviour
{
    public float Distance = 10f;
    public LayerMask layerMask;

    private GameObject currentTarget;

    void Update()
    {
        //transform.Rotate(Vector3.up, Time.deltaTime * 30);
        //transform.Rotate(new Vector3(0, 0, rotation));

        transform.Rotate(Vector3.up, Time.deltaTime * 30);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, Distance, layerMask))
        {
            if (currentTarget == null)
            {
                currentTarget = hit.transform.gameObject;
                OnRayCastEnter(currentTarget);
            }

            else if (currentTarget != hit.transform.gameObject)
            {
                OnRayCastLeave(currentTarget);
                currentTarget = hit.transform.gameObject;
                OnRayCastEnter(currentTarget);
            }

            OnRayCast(hit.transform.gameObject);
        }

        else if (currentTarget != null)
        {
            OnRayCastLeave(currentTarget);
            currentTarget = null;
        }
    }

    protected virtual void OnRayCastEnter(GameObject target)
    {

    }

    protected virtual void OnRayCastLeave(GameObject target)
    {

    }

    protected virtual void OnRayCast(GameObject target)
    {

    }
}