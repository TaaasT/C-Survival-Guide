using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IICommand 
{
    void Execute();

    void Undo();

}
