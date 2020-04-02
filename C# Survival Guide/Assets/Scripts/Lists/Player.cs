using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ListItem[] inventory = new ListItem[10];

    private ListItemDB itemDataBase;

    private void Start()
    {
        itemDataBase = GameObject.Find("ItemDB").GetComponent<ListItemDB>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            itemDataBase.AddItem(0, this);
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            itemDataBase.RemoveItem(0, this);
        }
    }
}
