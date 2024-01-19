using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Vector3 direction;
    public float speed = 5.0f;

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal"); /* 즉각적으로 반응하려면 Raw */
        direction.z = Input.GetAxisRaw("Vertical"); /* 위가 아니라 앞으로 이동하려면 Z축 */

        direction.Normalize(); /* 벡터의 정규화 (단위 벡터의 크기를 1로 맞춤) */

        transform.position = transform.position + direction * speed * Time.deltaTime;
        /* Time.deltaTime = 이전 프레임이 완료되기까지 걸린 시간 */ 
    }
}
