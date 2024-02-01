using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableZone : MonoBehaviour
{
    public ObjectPoolManager objectPoolManager;

    private void OnTriggerEnter(Collider other)
    {
        /* Using Tag Instead of Layer Mask */
        if(other.CompareTag("Container")) objectPoolManager.InsertQueue(other.gameObject);
    }
}
