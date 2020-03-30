using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodCha1 : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        cube.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
