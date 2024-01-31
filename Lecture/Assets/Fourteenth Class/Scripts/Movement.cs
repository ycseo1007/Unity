using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    public float speed = 1.0f;
    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
