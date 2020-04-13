using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingletion<T> : MonoBehaviour where T : MonoSingletion<T>
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
                Debug.Log(typeof(T).ToString() + " is Null");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this as T;

        Init();
    }

    public virtual void Init() 
    { 
        // optional to override
    }

}


public class Playaaa : MonoSingletion<Playaaa>
{
    public override void Init()
    {
        base.Init();

        Debug.Log("Player Initialized!");
    }

}