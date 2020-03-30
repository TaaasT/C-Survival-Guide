using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayInfo : MonoBehaviour
{
    // three ways of doing an array

    // declare the size (how many elements) through the inspector. most common

    //public string[] names;

    // second way rarly used
    //public string[] items = new string[5];

    // third way is to specify in code what those are. declaring size and populating the information now.
    //public int[] ages = new int[] { 5, 4, 3, 55, 66 };

    void Start()
    {
      //  Debug.Log(names[0]);
        //Debug.Log(ages[3]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
