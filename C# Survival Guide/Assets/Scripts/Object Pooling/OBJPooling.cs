using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJPooling : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(bulletPrefab);
        }
    }
}
