using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        /* Using Tad Instead of Layer Mask */
        if(other.CompareTag("Container")) other.gameObject.SetActive(false);
    }
}
