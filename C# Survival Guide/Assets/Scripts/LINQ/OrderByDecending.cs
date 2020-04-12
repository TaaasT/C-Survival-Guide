using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class OrderByDecending : MonoBehaviour
{
    public int[] quizGrades = { 44, 55, 32, 77, 95, 99, 88 };


    void Start()
    {                                                      // fixar dom i ordning.// vänder ordningen
        var passingGrades = quizGrades.Where(qg => qg > 69).OrderByDescending(g => g).Reverse();

        foreach (var grade in passingGrades)
        {
            Debug.Log("Grade: " + grade);
        }
    }


    void Update()
    {

    }
}
