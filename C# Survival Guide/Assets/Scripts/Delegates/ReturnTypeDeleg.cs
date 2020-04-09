using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTypeDeleg : MonoBehaviour
{
    //public delegate int CharacterLength(string text);
    //CharacterLength cl;

    public Func<string, int> CharacterLength;
    
    void Start()
    {
        //detta e exakt samma sak som att göra en delegate av det. detta e basic sättet.
        //int characterCount = GetCharacters("Jonathan");
        //Debug.Log("Character Count " + characterCount);

        //cl = GetCharacters;
        //Debug.Log(cl("Jon")); 

        CharacterLength = GetCharacters;

        int count = CharacterLength("jonathan");
        Debug.Log("Count " + count);

    }

    int GetCharacters(string name)
    {
        return name.Length;
    }
}
