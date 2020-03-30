using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysCha2 : MonoBehaviour
{

    public string[] names;
    public int[] age;
    public string[] carmodel;

    public int randomID;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomID = Random.Range(0, names.Length);
            Debug.Log(randomID);

            Debug.Log(names[randomID]);
            Debug.Log(age[randomID]);
            Debug.Log(carmodel[randomID]);
        }

    }
}
