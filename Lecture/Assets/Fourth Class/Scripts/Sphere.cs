using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour /* 컴포넌트로 인식되기 위한 필수 상속 */
{
    // Git Pull
    SphereCollider sphereCollider;

    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>(); // 주소를 받아와야 사용 가능
        sphereCollider.isTrigger = true;
    }

    void Update()
    {
        
    }
}
