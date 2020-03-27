using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge3TipCalculator : MonoBehaviour
{
    public int bill = 40;
    public float tip = 20.0f;
    public float total;


    // Start is called before the first frame update
    void Start()
    {
        float tipAmount = bill * (tip / 100);
        total = bill + tipAmount;
        Debug.Log("Your bill is: " + bill + " and your tip amout is: " + tipAmount + " so you owe: " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
