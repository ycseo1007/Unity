using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour /* ������Ʈ�� �νĵǱ� ���� �ʼ� ��� */
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
