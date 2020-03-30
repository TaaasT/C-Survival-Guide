using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodCha2 : MonoBehaviour
{
    public int health = 100;
    public bool isDead;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Damage(Random.Range(1, 10));
    }

    void Damage(int damageAmount)
    {
        if (Input.GetKeyDown(KeyCode.Space) && isDead == false)
        {
            health -= damageAmount;

            if (health < 1)
            {
                isDead = true;
                health = 0;
                Debug.Log("Player Has Died");
            }
        }
    }
}
