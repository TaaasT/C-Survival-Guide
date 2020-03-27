using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cha4 : MonoBehaviour
{
    // create a program that let's you increment the speed when you hit the S key
    // A key decrements the speed. // when the speed is greater than 20 you need to print "Slow down"
    // when the speed is 0 print "Speed up"
    //you cant go below 0.

    public int speed;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            speed += 5;
        }
        
        if(Input.GetKeyDown(KeyCode.A))
        {
            speed -= 5;
        }

        if(speed >= 20)
        {
            Debug.Log("Slow Down");
        }
        else if(speed == 0)
        {
            Debug.Log("Speed Up");

        }

        if (speed < 0)
        {
            speed = 0;
        }
    }

}
