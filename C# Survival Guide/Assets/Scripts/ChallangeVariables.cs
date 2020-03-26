using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallangeVariables : MonoBehaviour
{
    string myName = "Arber";
    int myAge = 28;
    float myspeed = 5.3f;
    int health = 100;
    int score = 120;
    bool hasKey;
    int ammo = 55;

    void Start()
    {
        Debug.Log("My name is " + myName + "and my age is " + myAge);//etc
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
