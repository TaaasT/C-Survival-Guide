using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysCha3 : MonoBehaviour
{
    public GameObject[] cubes;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach(var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }
    }
}
