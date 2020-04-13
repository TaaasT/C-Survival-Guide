using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonInfo : MonoBehaviour
{
    private static SingletonInfo instance;
    public static SingletonInfo Instance
    {
        get
        {
            if(instance == null)
            
                Debug.LogError("The Gamemanager is NULL");

                return instance;
            
        }
    }

    private void Awake()
    {
        instance = this;
    }

}
