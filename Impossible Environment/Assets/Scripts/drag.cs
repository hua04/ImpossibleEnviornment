using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    public Camera cam;
    Vector3 mousePosition;
  
    private Vector3 GetMousePos()
    {
        return cam.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition-GetMousePos();
    }

    private void OnMouseDrag()
    {
        transform.position = cam.ScreenToWorldPoint(Input.mousePosition-mousePosition);
    }
}
