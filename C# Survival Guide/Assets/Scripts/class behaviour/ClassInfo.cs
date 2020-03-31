using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassInfo : MonoBehaviour
{
    ClassInfo2 sword;
    ClassInfo2 hammer;
    ClassInfo2 bread;

    void Start()
    {
        // two diffrent ways to make an item.
        sword = new ClassInfo2();
        sword.name = "Sword";
        sword.id = 1;
        sword.description = "This is a sword!";

        hammer = new ClassInfo2("Hammer", 2, "This is a hammer.");
        
        //third way to do same thing.
        bread = CreateItem("bread", 3, "I can eat this.");
    }
    
  private ClassInfo2 CreateItem(string name, int id, string description)
    {
        ClassInfo2 item = new ClassInfo2(name, id, description);

        return item;
    }
}
