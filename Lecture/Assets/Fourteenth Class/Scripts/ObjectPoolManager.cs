using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public int createCount = 5; /* This value can be modified in the inspector */
    public GameObject container;
    public Queue<GameObject> objectQueue = new Queue<GameObject>();
    /*
      Queue<GameObject> : Create a queue and define data(Parameter) type as GameObject
      objectQueue : The name will be saved into the stack
      new Queue<GameObject>() : Allocate memory space for objectQueue
    */

    void Start()
    {
        CreateContainer();
    }

    public void CreateContainer()
    {
        for (int i = 0; i < createCount; i++)
        {
            GameObject prefab = Instantiate(container);
            
            prefab.gameObject.SetActive(false);

            objectQueue.Enqueue(prefab);
        }
    }

    public void GetQueue()
    {
        GameObject prefab = objectQueue.Dequeue();

        prefab.SetActive(true);
    }

    public void InsertQueue(GameObject prefab)
    {
        prefab.SetActive(false);

        prefab.transform.position = Vector3.zero;

        objectQueue.Enqueue(prefab);
    }
}
