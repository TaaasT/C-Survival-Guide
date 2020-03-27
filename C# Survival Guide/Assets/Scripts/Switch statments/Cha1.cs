using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cha1 : MonoBehaviour
{
    public int points;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            points = 50;
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            points = 100;
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }

        switch (points)
        {
            case 50:
                Debug.Log("Points are 50!");
                break;
            case 100:
                Debug.Log("Points are 100!");
                break;
            default:
                Debug.Log("You need 50 or 100 points to recive a message");
                break;
        }



        /*
        if(points == 50)
        {
            Debug.Log("Points are 50!");
        }
        else if(points == 100)
        {
            Debug.Log("Points are 100!");
        }
        else
        {
            Debug.Log("You need 50 or 100 points to recive a message");
        }*/
    }
}
