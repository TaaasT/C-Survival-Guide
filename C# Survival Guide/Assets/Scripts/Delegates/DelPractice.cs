using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelPractice : MonoBehaviour
{
    public Action<int, int> Sum;

    private void Start()
    {
        Sum = (a, b) =>
        {
            var total = a + b;
            if (total < 100)
            {
                Debug.Log("Total is less than 100");
            }

            Debug.Log("Total " + total);
        };

        Sum(5, 2);
    }

}

public class DelPractice2 : MonoBehaviour
{
    public Action onGetName;

    private void Start()
    {
        // man kan ha flera saker i samma men då måste man ha curlybrackets och avsluta med ;
        onGetName = () =>
        {
            Debug.Log("Name: " + gameObject.name);
        };

        onGetName();
    }

}

public class DelPractice3 : MonoBehaviour
{
    public Func<int> onGetname;

    private void Start()
    {
        onGetname = () => this.gameObject.name.Length;

        int charachterCount = onGetname();

        Debug.Log("Character Count " + charachterCount);
    }

   /* int GetName()
    {
        return this.gameObject.name.Length;
    }*/
}

public class DelPractice4 : MonoBehaviour
{
    public Func<int, int, int> onCalculateSum;

    private void Start()
    {
        onCalculateSum = (a, b) => a + b;
        Debug.Log(onCalculateSum(5, 5));
    }

    int CalculateSum(int a, int b)
    {
        return a + b;
    }
}