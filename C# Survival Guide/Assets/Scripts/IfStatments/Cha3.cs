using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cha3 : MonoBehaviour
{
    // create a program that whne you hit the space key, you increment a score value. when that score value is greater
    //than 50. you turn the cube green. at the start of the program, set the cube to red. 
    // use this for initialization
    public int score;


    public GameObject cube;

    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
        }

        if(score >= 50)
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
