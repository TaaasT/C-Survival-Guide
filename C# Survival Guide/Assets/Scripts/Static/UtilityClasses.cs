using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// by making a class static it cannot inherit anything.
// and everything in this class has to be static in order for it to work.
public static class UtilityClasses
{
    public static void CreateObject()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public static void SetPositionToZero(GameObject obj)
    {
        obj.transform.position = Vector3.zero;
    }

}
