using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCha : MonoBehaviour
{

    private void Start()
    {
        DelCha.onTeleport += Spawn;
    }

    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
    }

    private void OnDisable()
    {
        DelCha.onTeleport -= Spawn;
    }

}
