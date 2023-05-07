using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select : MonoBehaviour
{
    public Camera Cam;
    private GameObject selectedObject;
    private Vector3 screenPoint;
    private Vector3 offset;

    private void Start()
    {
        Cursor.visible = true;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(selectedObject == null)
            {
                RaycastHit hit = CastRay();
                if (hit.collider != null)
                {
                    if (hit.collider.CompareTag("not moving"))
                    {
                        return;
                    }
                    selectedObject=hit.collider.gameObject;
                    Cursor.visible = false;
                }
            }
            else
            {Vector3 position=new Vector3(Input.mousePosition.x, Input.mousePosition.y, Cam.WorldToScreenPoint(selectedObject.transform.position).z);
                Vector3 worldPosition = Cam.ScreenToWorldPoint(position);
                selectedObject.transform.position = new Vector3(worldPosition.x, 1f,worldPosition.z);

                selectedObject = null;
                Cursor.visible = true;


            }
        }
        if (selectedObject != null)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Cam.WorldToScreenPoint(selectedObject.transform.position).z);
            Vector3 worldPosition = Cam.ScreenToWorldPoint(position);
            selectedObject.transform.position = new Vector3(worldPosition.x, 2f, worldPosition.z);

            if (Input.GetMouseButtonDown(1))
            {
                selectedObject.transform.rotation = Quaternion.Euler(new Vector3
                    (selectedObject.transform.rotation.eulerAngles.x,
                    selectedObject.transform.rotation.eulerAngles.y + 90f,
                    selectedObject.transform.rotation.eulerAngles.z
                    ));
            }
        }
    }

    private RaycastHit CastRay()
    {
        Vector3 screenMousePosFar = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Cam.farClipPlane
            );
        Vector3 screenMousePosNear= new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Cam.nearClipPlane
            );
        Vector3 worldMousePosFar = Cam.ScreenToWorldPoint(screenMousePosFar);
        Vector3 worldMousePosNear = Cam.ScreenToWorldPoint(screenMousePosNear);
        RaycastHit hit;
        Physics.Raycast(worldMousePosNear, worldMousePosFar - worldMousePosNear, out hit);
        return hit;
    }

    
}
