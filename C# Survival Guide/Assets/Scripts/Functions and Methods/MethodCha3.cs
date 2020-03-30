using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodCha3 : MonoBehaviour
{
    public Vector3[] positions;
    private int randomIndex;


    void Start()
    {
        randomIndex = GetRandom();

        Debug.Log("random index " + randomIndex);

        transform.position = GetPosition(randomIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetRandom()
    {
        return Random.Range(0, positions.Length);
    }

    Vector3 GetPosition(int index)
    {
        return positions[index];
    }
}
