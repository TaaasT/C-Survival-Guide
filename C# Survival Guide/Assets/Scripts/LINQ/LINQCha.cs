using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQCha : MonoBehaviour
{
    public int[] quizGrades = { 44, 55, 32, 77, 95, 99, 88 };


    void Start()
    {
        var passingGrades = quizGrades.Where(qg => qg > 69); 
        
        foreach(var grade in passingGrades)
        {
            Debug.Log("Grade: " + grade);
        }
    }

    
    void Update()
    {
        
    }
}
