using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCha1 : MonoBehaviour
{
    public static string company = "GameDevHQ";
    public string employeeName;

    public abstract void CalculateMonthlySalary();
}


public class PartTime : AbstractCha1
{
    public int hoursWorked;
    public int hourlyRate;


    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }
}


public class FullTime : AbstractCha1
{
    public int Salary;

    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }


}
