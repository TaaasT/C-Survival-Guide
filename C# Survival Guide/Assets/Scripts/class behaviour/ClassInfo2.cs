using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//måste göra såhär annars kan vi inte se det i unity!
[System.Serializable]
public class ClassInfo2 
{
    public string name;
    public int id;
    public string description;

    //i can leave this constructor empty if i want 
    public ClassInfo2()
    {

    }
    //and make another constructor that holds params.
    public ClassInfo2(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }
}
