using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCha1 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChaHelper.ChangeColor(this.gameObject, Color.red, true);
        }
    }
}
