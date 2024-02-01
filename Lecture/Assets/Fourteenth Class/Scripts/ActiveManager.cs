using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveManager : MonoBehaviour
{
    [SerializeField] ObjectPoolManager objectPoolManager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(5f);

    void Start()
    {
        StartCoroutine(Create()); /* Coroutine ���� ������ */
    }

    IEnumerator Create()
    {
        while (true)
        {
            yield return waitForSeconds;

            objectPoolManager.GetQueue();
        }

    }
}
