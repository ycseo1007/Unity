using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour /* 컴포넌트로 인식되기 위한 필수 상속 */
{
    SphereCollider sphereCollider;

    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
    }

    void Update()
    {
        
    }
}
