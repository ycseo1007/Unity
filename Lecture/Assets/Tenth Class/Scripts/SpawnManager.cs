using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnObject;
    public Transform [] spawnTransforms;

    void Start()
    {
        StartCoroutine(Spawn());

        for (int i = 0; i < 5; i++) Debug.Log("i°ª : " + i);

        Instantiate(spawnObject, spawnTransforms[Random.Range(0, spawnTransforms.Length)]);
    }

    IEnumerator Spawn()
    {
        Debug.Log("Coroutine Starts.");

        yield return new WaitForSeconds(5f);

        Debug.Log("Coroutine Idle.");
    }
}
