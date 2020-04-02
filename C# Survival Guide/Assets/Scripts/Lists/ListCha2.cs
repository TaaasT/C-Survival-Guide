using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListCha2 : MonoBehaviour
{
    public GameObject[] spawnList = new GameObject[3];
    public List<GameObject> objectsCreated = new List<GameObject>();

    private bool initColorChange;
    
    public int SpawnCount { get; set; }

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(SpawnCount == 10)
            {
                initColorChange = true;
                return;
            }

            var objectToSpawn = spawnList[Random.Range(0, spawnList.Length)];
            var pos = new Vector3(-10, 10, 0);
            
            GameObject go = Instantiate(objectToSpawn, pos, Quaternion.identity) as GameObject;

            objectsCreated.Add(go);

            SpawnCount++;
        }

        if(initColorChange == true)
        {
            initColorChange = false;

            foreach(var obj in objectsCreated)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }

            objectsCreated.Clear();
        }
    }
}
