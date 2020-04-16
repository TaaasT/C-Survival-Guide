using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CCommandManager : MonoBehaviour
{
    private static CCommandManager _instance;
    public static CCommandManager Instance
    {
        get
        {
            if(_instance == null)
            
                Debug.Log("CCM is Null");

                return _instance;
            
        }
    }

    private List<IICommand> _commandBuffer = new List<IICommand>();

    private void Awake()
    {
        _instance = this;
    }

    public void AddCommand(IICommand command)
    {
        _commandBuffer.Add(command);
    }

    public void Rewind()
    {
        StartCoroutine(RewindRoutine());
    }

    IEnumerator RewindRoutine()
    {
        Debug.Log("Rewinding.");
        foreach(var command in Enumerable.Reverse(_commandBuffer))
        {
            command.Undo();
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("finished");
    }

    public void Play()
    {
        StartCoroutine(PlayRoutine());
    }

    IEnumerator PlayRoutine()
    {
        Debug.Log("Playing.");
        foreach (var command in (_commandBuffer))
        {
            command.Execute();
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("finished");
    }

}
