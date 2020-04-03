using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumsInfo : MonoBehaviour
{
    public enum LevelSelector
    {
        //kan åxo skriva vilket nr som på dom två första. annars defult går det från 0 till i detta fall 3.
        Easy = 0, // 0  
        Normal = 54, // 1    
        Hard, // 2
        Expert // 3
    }

    public LevelSelector currentLevel;

    void Start()
    {
        switch(currentLevel)
        {
            case LevelSelector.Easy:
                Debug.Log("You selected Easy"); // här skriver man koden som ska hända!
                break;
            case LevelSelector.Normal:
                break;
            case LevelSelector.Hard:
                break;
            case LevelSelector.Expert:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
