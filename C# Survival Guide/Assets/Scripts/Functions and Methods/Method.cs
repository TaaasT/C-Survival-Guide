using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour
{
    public int health;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Damage(5);
        }
    }

    void Damage(int damageAmound)
    {
        health -= damageAmound;

        if(health < 1)
        {
            health = 0;
            Destroy(this.gameObject);
        }
    }
}
