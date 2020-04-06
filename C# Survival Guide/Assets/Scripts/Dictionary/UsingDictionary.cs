using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingDictionary : MonoBehaviour
{
    /*public Dictionary<string, int> people = new Dictionary<string, int>();*/

    public Dictionary<int, string> books = new Dictionary<int, string>();

    void Start()
    {
        /*people.Add("Jon", 26);
        people.Add("James", 55);
        people.Add("Rachel", 31);
        people.Add("Yin", 34);

        int rachelsAge = people["Rachel"];

        Debug.Log("Rachels Age: " + rachelsAge);*/

        books.Add(0, "Ultimate guide");
        books.Add(1, "The Unity C# Surv.");

        foreach(KeyValuePair<int, string> book in books)
        {
            Debug.Log("Book: " + book.Value);
        }

    }

}
