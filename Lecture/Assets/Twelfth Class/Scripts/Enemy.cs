using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 100;
    public void SetHP(float damage)
    {
        health -= damage;
        
        if (health <= 0)
        {
            Destroy(gameObject); /* ���� ������Ʈ�� �ı��ϴ� �Լ� */
        }
    }
}
