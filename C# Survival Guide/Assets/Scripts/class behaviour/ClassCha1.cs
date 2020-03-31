using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassCha1 : MonoBehaviour
{
    public Customer john;
    public Customer jannet;
    public Customer jessica;

    void Start()
    {
        john = new Customer("John", "Svensson", 24, "Male", "Byggare");
        jannet = new Customer("Jannet", "", 55, "Female", "Instructor");
        jessica = new Customer("Jessica", "Lang", 23, "Female", "Scientist");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
