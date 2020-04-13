using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletionCha : MonoBehaviour
{
    private static SingletionCha _instance;
    public static SingletionCha Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Is null");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
}
