using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPPlayer : MonoBehaviour
{
    IICommand moveUp, moveDown, moveLeft, moveRight;
    [SerializeField]
    private float _speed = 2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            moveUp = new MoveUpCommand(this.transform, _speed);
            moveUp.Execute();
        }
        else if(Input.GetKey(KeyCode.S))
        {
            moveDown = new MoveDownCommand(this.transform, _speed);
            moveDown.Execute();
        }
        else if(Input.GetKey(KeyCode.A))
        {
            moveLeft = new MoveLeftCommand(this.transform, _speed);
            moveLeft.Execute();
        }
        else if(Input.GetKey(KeyCode.D))
        {
            moveRight = new MoveRightCommand(this.transform, _speed);
            moveRight.Execute();
        }
    }
}
