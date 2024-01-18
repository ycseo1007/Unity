using JetBrains.Rider.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody Rigidbody;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() /* ������ ���� ���� ������Ʈ */
    {
        Rigidbody.velocity += 3 * Vector3.right;
    }

    private void OnCollisionEnter(Collision collision) /* ������Ʈ �� ������ �浹 �� ȣ��Ǵ� �̺�Ʈ �Լ� */
    {
        Debug.Log("�浹�� �Ǿ��� ��");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹 ���� ��");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹�� ������ ��");
    }
}
