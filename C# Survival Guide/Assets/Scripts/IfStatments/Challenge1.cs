using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge1 : MonoBehaviour
{

    [SerializeField] int score;
    [SerializeField] int points = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            score += points;
        }

        if(score >= 50)
        {
            Debug.Log("You are awsome");
        }
    }
}
