using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    private float degree;

    void Update()
    {
        degree += Time.deltaTime;

        if (degree >= 360) degree = 0;

        RenderSettings.skybox.SetFloat("_Rotation", degree);
    }
}
