using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaExpression : MonoBehaviour
{
    public Func<string, int> CharacterLength;

    void Start()
    {
        //detta e lambda expression. det e samma sak längst nere.
        CharacterLength = (name) => name.Length;

        int count = CharacterLength("Jonathan");

        Debug.Log("Count " + count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //som detta!
    /*int GetCharacters(string name)
    {
        return name.Length;
    }*/

}
