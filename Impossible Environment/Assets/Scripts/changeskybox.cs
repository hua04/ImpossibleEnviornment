using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class changeskybox : MonoBehaviour
{
    private select selectedObject;
    private Vector3 correctPosition;
    public Material dark;
    // Start is called before the first frame update
    void Awake()
    {
       
        correctPosition = transform.position;
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, correctPosition) < 4f)
        {
            transform.position = correctPosition;
            RenderSettings.skybox = dark;

        }
    }
}
