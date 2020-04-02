using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListItemDB : MonoBehaviour
{
    public List<ListItem> itemDataBase = new List<ListItem>();

  
    public void AddItem(int itemID, Player player)
    {
        foreach (var item in itemDataBase)
        {
            if (item.id == itemID)
            {
                Debug.Log("WE have a match!");
                player.inventory[0] = item;
                return;
            }
        }
        Debug.Log("Item does not exist!");
    }

    public void RemoveItem(int ItemID, Player player)
    {
        foreach(var item in itemDataBase)
        {
            if(item.id == ItemID)
            {
                player.inventory[0] = null;
            }
        }
    }

}
