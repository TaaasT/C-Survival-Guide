using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cha2 : MonoBehaviour
{
    public GameObject cube;

    private int nextColor;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            nextColor = 0;
        }
        
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            nextColor = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            nextColor = 2;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            nextColor = 3;
        }

        switch(nextColor)
        {
            case 0:
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 1:
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                cube.GetComponent<Renderer>().material.color = Color.black;
                break;
            default:
                Debug.Log("Invalid selection");
                break;
        }
    }

}
