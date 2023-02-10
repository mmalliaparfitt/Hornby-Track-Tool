using System.Collections;
using UnityEngine;

class DragTransform : MonoBehaviour
{
    private Color mouseOverColor = Color.blue;
    private Color originalColor = Color.yellow;
    private bool dragging = false;
    private float distance;


    void OnMouseEnter()
    {
        Debug.Log("Mouse Over");
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
    }

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
        Debug.Log("Mouse Down");
    }

    void OnMouseUp()
    {
        dragging = false;
        Debug.Log("Mouse Up");
    }

    void Update()
    {
        if (dragging)
        {
            Debug.Log("Dragging");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            rayPoint.y = 0;
            transform.position = rayPoint;
        }
    }
}