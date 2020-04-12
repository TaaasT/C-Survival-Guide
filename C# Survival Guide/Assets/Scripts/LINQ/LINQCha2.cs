using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class LINQItem
{
    public string name;
    public int itemID;
    public int buff;
}

public class LINQCha2 : MonoBehaviour
{
    public List<LINQItem> items;

    void Start()
    {
        var result = items.Any(item => item.itemID == 3);
        Debug.Log("Result " + result);

        var results = items.Where(item => item.buff > 20);

        foreach(var item in results)
        {
            Debug.Log("Name: " + item.name);
        }

        var resultss = items.Average(item => item.buff);
        Debug.Log("Average " + resultss);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
