using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListItemDB : MonoBehaviour
{
    public List<ListItem> itemDataBase = new List<ListItem>();

  
    public void AddItem(int itemID)
    {
        foreach (var item in itemDataBase)
        {
            if (item.id == itemID)
            {
                Debug.Log("WE have a match!");
                return;
            }
        }
        Debug.Log("Item does not exist!");
    }

    public void RemoveItem(int ItemID)
    {

    }

}
