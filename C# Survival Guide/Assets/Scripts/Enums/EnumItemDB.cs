using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumItemDB : MonoBehaviour
{
    public List<EnumsClass> itemDB = new List<EnumsClass>();

   
    void Start()
    {
        itemDB[0].Action();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
