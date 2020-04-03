using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnumsClass
{
    public string name;
    public int ID;
    public Sprite icon;

    public enum ItemType
    {
        None,
        Weapon,
        Consumable
    }

    public ItemType itemType;

    public void Action()
    {
        switch(itemType)
        {
            case ItemType.Weapon:
                Debug.Log("This is a weapon");
                break;

            case ItemType.Consumable:
                Debug.Log("This is a consumable");
                break;

            case ItemType.None:
                Debug.Log("There is no type");
                break;

        }
    }

}
