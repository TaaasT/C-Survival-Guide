using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoProperties : MonoBehaviour
{
   public bool IsGameOver { get; private set; }

    void Start()
    {
        IsGameOver = false;

        if(IsGameOver)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}
