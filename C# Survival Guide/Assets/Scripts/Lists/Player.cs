using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ListItem[] inventory;

    private ListItemDB itemDataBase;

    private void Start()
    {
        itemDataBase = GameObject.Find("ItemDB").GetComponent<ListItemDB>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            itemDataBase.AddItem(0);
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            itemDataBase.RemoveItem(0);
        }
    }
}
