using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveManager : MonoBehaviour
{
    [SerializeField] ObjectPoolManager objectPoolManager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(5f);

    void Start()
    {
        StartCoroutine(Create()); /* Coroutine 위해 무조건 */
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
