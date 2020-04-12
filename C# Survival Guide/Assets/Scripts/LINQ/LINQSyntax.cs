using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQSyntax : MonoBehaviour
{

    int[] scores = new int[] { 97, 92, 81, 60 };

    void Start()
    {
        //Detta e Query syntax. 
        var scoreQuerySyntax =
            from score in scores
            where score > 80
            select score;

        //Detta e samma som ovan!!// detta e method syntax
        var scoreQuery = scores.Where(score => score > 80);

        foreach(var score in scoreQuery)
        {
            Debug.Log("Score: " + score);
        }

    }

  
}
