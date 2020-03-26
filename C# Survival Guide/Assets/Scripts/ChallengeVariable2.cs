using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeVariable2 : MonoBehaviour
{
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public float attackStrenght;

    void Start()
    {
        Debug.Log("Name: " + itemName);
        Debug.Log("Desciption: " + itemDescription);
        Debug.Log("DMG: " + attackStrenght);
    }

}
