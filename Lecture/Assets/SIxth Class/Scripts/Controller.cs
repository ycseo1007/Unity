using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Vector3 direction;
    public float speed = 5.0f;

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal"); /* �ﰢ������ �����Ϸ��� Raw */
        direction.z = Input.GetAxisRaw("Vertical"); /* ���� �ƴ϶� ������ �̵��Ϸ��� Z�� */

        direction.Normalize(); /* ������ ����ȭ (���� ������ ũ�⸦ 1�� ����) */

        transform.position = transform.position + direction * speed * Time.deltaTime;
        /* Time.deltaTime = ���� �������� �Ϸ�Ǳ���� �ɸ� �ð� */ 
    }
}
