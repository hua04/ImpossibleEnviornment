using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{public Camera Cam;
    Vector3 pos;
    public float offset = 3f;

    void Update()
    {
        pos = Input.mousePosition;
        pos.z = offset;
        transform.position = Cam.ScreenToWorldPoint(pos);
    }
}
