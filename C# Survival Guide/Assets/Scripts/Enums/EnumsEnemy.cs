using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumsEnemy : MonoBehaviour
{
    public enum EnemyState
    {
        Patroling,
        Attacking,
        Chasing,
        Death
    }

    public EnemyState currentState;

    void Start()
    {
        currentState = EnemyState.Patroling;
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState)
        {
            case EnemyState.Patroling:
                Debug.Log("Patroling");
                if(Time.time > 5)
                {
                    currentState = EnemyState.Chasing;
                }
                break;
            case EnemyState.Attacking:
                Debug.Log("Attacking");
                break;
            case EnemyState.Chasing:
                Debug.Log("Chasing");
                break;
            case EnemyState.Death:
                Debug.Log("Death");
                break;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            currentState = EnemyState.Attacking;
        }

    }
}
