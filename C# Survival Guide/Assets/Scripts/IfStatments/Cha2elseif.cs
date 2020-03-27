using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cha2elseif : MonoBehaviour
{
    // 5 quiz grades
    // calculate the average quiz grades
    //that prints out the grade average based on this scenario
    public int quiz1, quiz2, quiz3, quiz4, quiz5;
    public int average;

        //print A => 90
        // print B = >=80 but less than 90
        // print C = >70 <80
        // print F less than 70



    void Start()
    {
        quiz1 = Random.Range(50, 150);
        quiz2 = Random.Range(50, 150);
        quiz3 = Random.Range(50, 150);
        quiz4 = Random.Range(50, 150);
        quiz5 = Random.Range(50, 150);

        average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;

        if (average >= 90)
        {
            Debug.Log("A");
        }
        else if (average >= 80 && average < 90)
        {
            Debug.Log("B");
        }
        else if (average >= 70 && average < 80)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("F");
        }
    }

   void Update()
   {

   }
}
