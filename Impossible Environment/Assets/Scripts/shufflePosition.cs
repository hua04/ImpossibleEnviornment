using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;

public class shufflePosition : MonoBehaviour
{
    private select selectedObject;
    private Vector3 correctPosition;
    private float Angle;
    // Start is called before the first frame update
    void Awake() 
    {        float[] angle = { 0f, 90f, 180f };
        Angle = angle[Random.Range(0, 3)];
        correctPosition = transform.position;
        transform.position=new Vector3(Random.Range(-671.17f, -685.37f), -0.1900024f, Random.Range(153.75f, 165.3f));
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y+Angle, transform.rotation.eulerAngles.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, correctPosition)<1f) {
            transform.position = correctPosition;
        }
    }
}
