using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysCha1 : MonoBehaviour
{

    public string[] names;
    public int[] age;
    public string[] carmodel;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(names[4]);
            Debug.Log(age[4]);
            Debug.Log(carmodel[4]);
        }

    }
}
