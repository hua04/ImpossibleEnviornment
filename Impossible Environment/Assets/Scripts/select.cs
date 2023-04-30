using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select : MonoBehaviour
{
    Vector3 mousePositionOffset;
    public Camera Cam;

    private Vector3 GetMouseWorldPosition()
    {
        return Cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDown()
    {
        mousePositionOffset=gameObject.transform.position-GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        transform.position=GetMouseWorldPosition()+mousePositionOffset;
    }

   
}
