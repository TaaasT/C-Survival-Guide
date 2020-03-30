using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayLoops : MonoBehaviour
{
    public string[] itemName;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i < itemName.Length; i++)
            {
                Debug.Log(itemName[i]);
            }

            foreach(var item in itemName)
            {
                if (item == "Sword")
                {
                    Debug.Log(item);
                }
            }
        }
    }
}
