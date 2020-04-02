using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsCha1 : MonoBehaviour
{
    public List<string> names = new List<string>();

    void Start()
    {
        foreach( var name in names)
        {
            Debug.Log(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var nameToRemove = names[Random.Range(0, names.Count)];

            names.Remove(nameToRemove);
            
            foreach (var name in names)
            {
                Debug.Log(name);
            }

            Debug.Log("We removed " + nameToRemove);

        }
    }
}
