using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemID;
    public string name;
    public string description;
}

public class ArrayLoops : MonoBehaviour
{
    //public string[] itemName;

    public Item[] myItems;

    void Start()
    {
        /*foreach(var item in myItems)
        {
            Debug.Log(item.name);
        }

        foreach(var item in myItems)
        {
            if(item.itemID == 7)
            {
                Debug.Log("you have it!");
            }
            else
            {
                Debug.Log("You dont have this item");
            }
        }*/

        for(int i = 0; i < myItems.Length; i++)
        {
            if(myItems[i].itemID == 7)
            {
                Debug.Log("You have item!");
            }
            else
            {
                Debug.Log("You do not have item");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       /* if(Input.GetKeyDown(KeyCode.Space))
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
        }*/

        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            int randomID = Random.Range(0, myItems.Length);
            
            for (int i = 0; i < myItems.Length; i++)
            {
                Debug.Log(myItems[randomID].name);
            }
        }*/
    }
}
