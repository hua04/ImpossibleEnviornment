using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;

public class shufflePosition : MonoBehaviour
{
    public select selectedObject;
    private Vector3 correctPosition;
    private float Angle;
    // Start is called before the first frame update
    void Awake() 
    {        float[] angle = { 0f, 90f, 180f };
        Angle = angle[Random.Range(0, 3)];
        correctPosition = transform.position;
        transform.position=new Vector3(Random.Range(5,7),Random.Range(5,7));
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y+Angle, transform.rotation.eulerAngles.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, correctPosition)<0.5f) {
            transform.position = correctPosition;
        }
    }
}
