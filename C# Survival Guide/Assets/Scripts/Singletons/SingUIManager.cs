using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingUIManager : MonoBehaviour
{
    private static SingUIManager _instance;
    public static SingUIManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("UIManager is null");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

}
