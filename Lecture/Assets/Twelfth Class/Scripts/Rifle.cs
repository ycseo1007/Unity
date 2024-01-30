using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rifle : MonoBehaviour
{
    Ray ray;
    RaycastHit raycastHit;
    [SerializeField] LayerMask layerMask;

    void Update()
    {
        // Debug.DrawLine(ray.origin, raycastHit.point);

        if (Input.GetButtonDown("Fire1"))
        { 
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100, layerMask)) /* Physics.Raycast( ���� ����, �浹�� ������Ʈ ����, ������ ����, ���̾� ����ũ ���� )*/
            {
                Enemy enemy = raycastHit.collider.GetComponent<Enemy>();
                enemy.SetHP(10);

                
            }
        }


        
    }
}
