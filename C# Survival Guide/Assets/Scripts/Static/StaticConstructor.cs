﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee
{
    public int employeeID;
    public int first, last;
    public int salary;

    public static string company;

    public Employee()
    {
        Debug.Log("Instance Members Initialized");
    }

    static Employee()
    {
        company = "GameDevHQ";
        Debug.Log("Initialized Static Members");
    }
}


public class StaticConstructor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Employee e1 = new Employee();
        var e2 = new Employee();
        var e3 = new Employee();
        var e4 = new Employee();
        var e5 = new Employee();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
