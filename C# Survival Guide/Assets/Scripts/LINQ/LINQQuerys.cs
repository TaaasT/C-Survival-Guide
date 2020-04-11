using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQQuerys : MonoBehaviour
{
    public string[] names = { "jon", "alex", "julie", "jessie", "david", "mark", "matt" };

    void Start()
    {
        var nameFound = names.Any(name => name == "jon");

        Debug.Log("Name found: " + nameFound);
    }

    void Update()
    {
        
    }

}
