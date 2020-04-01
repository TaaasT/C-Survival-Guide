using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropCha1 : MonoBehaviour
{

    // autoproperty
    public float speed { get; private set; }

    //property
    /*public float Speed
    {
        get
        {
            return speed;
        }
        private set
        {
            speed = value;
        }

    }*/

    void Start()
    {
        /*Speed = 10f;
        Debug.Log(Speed);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
