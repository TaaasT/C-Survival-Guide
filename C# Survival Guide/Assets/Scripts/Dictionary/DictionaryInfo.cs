using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryInfo : MonoBehaviour
{
    //dictionary e typ samma som list. skillnaden e att med dictionary så kan jag snabbt filtrera till rätt item eftersom det kräver en int.

    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    private void Start()
    {
        //deklarerar här
        Item sword = new Item();
        sword.name = "Sword";
        sword.itemID = 0;

        itemDictionary.Add(0, sword);

        //how to retrieve it
        var item = itemDictionary[0];


    }
    
}
