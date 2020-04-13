using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazyInstantiation : MonoBehaviour
{
    private static LazyInstantiation _instance;
    public static LazyInstantiation Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("UI Manager");
                go.AddComponent<SingUIManager>();
            }
            

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
}
