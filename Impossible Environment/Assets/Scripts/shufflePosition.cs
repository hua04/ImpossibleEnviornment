using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class shufflePosition : MonoBehaviour
{
    public GameObject appearobject;
    public GameObject appearobject2;
    public float Xmaxrange;
    public float Xminrange;
    public float Ynumber;
    public float Zmaxrange;
    public float Zminrange;
    private select selectedObject;
    private Vector3 correctPosition;
    private float Angle;
    // Start is called before the first frame update
    void Awake() 
    {        float[] angle = { 0f, 90f, 180f };
        Angle = angle[Random.Range(0, 3)];
        correctPosition = transform.position;
        transform.position=new Vector3(Random.Range(Xminrange, Xmaxrange), Ynumber, Random.Range(Zminrange,Zmaxrange));
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y+Angle, transform.rotation.eulerAngles.z));
        appearobject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, correctPosition)<4f) {
            transform.position = correctPosition;
            appearobject.SetActive(true);
            appearobject2.SetActive(true);
        }
    }
}
