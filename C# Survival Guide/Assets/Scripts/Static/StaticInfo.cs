using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticItem
{
    //what is the difference between instance members and static members?
    //Static members live for the life of the program. and is shared among all the classes.
    //Instance members have instances of themselves for exampel a custom class.

    // these are instance members. they are being copied in StaticInfo
    public string name;
    public int itemID;

    // this is a static member. it is shared among the items in StaticInfo.
    public static int itemCount;

    public StaticItem()
    {
        itemCount++;
    }
}

public class StaticInfo : MonoBehaviour
{

    
    void Start()
    {
        StaticItem sword = new StaticItem();
        StaticItem bread = new StaticItem();
        StaticItem cape = new StaticItem();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
