using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rifle : MonoBehaviour
{
    Ray ray;
    RaycastHit raycastHit;

    void Update()
    {
        Debug.DrawLine(ray.origin, raycastHit.point); /* 디버그 위한 시각화 */

        if (Input.GetButtonDown("Fire1"))
        { 
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100)) /* Physics.Raycast( 광선 정보, 충돌한 오브젝트 정보, 광선의 길이, 레이어 마스크 설정 )*/
            {
                Enemy enemy = raycastHit.collider.GetComponent<Enemy>();
                enemy.SetHP(10);

                
            }
        }


        
    }
}
