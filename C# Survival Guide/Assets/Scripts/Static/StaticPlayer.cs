using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticPlayer : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UtilityClasses.CreateObject();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            UtilityClasses.SetPositionToZero(this.gameObject);
        }
    }
}
