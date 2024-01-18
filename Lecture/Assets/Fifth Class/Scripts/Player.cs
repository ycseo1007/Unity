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

    private void FixedUpdate() /* 프레임 변동 없이 업데이트 */
    {
        Rigidbody.velocity += 3 * Vector3.right;
    }

    private void OnCollisionEnter(Collision collision) /* 오브젝트 간 물리적 충돌 시 호출되는 이벤트 함수 */
    {
        Debug.Log("충돌이 되었을 때");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 중일 때");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌이 끝났을 때");
    }
}
