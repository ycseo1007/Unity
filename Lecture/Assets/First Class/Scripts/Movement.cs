using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    #region Number. Caption
    /* Annotation */
    #endregion

    char grade = 'A'; /* = Private */
    public float speed = 0;
    private Vector3 direction;
    
    private void Start() /* ������Ʈ ���� ���� �� �� �� ȣ�� */
    {
        Debug.Log("grade : " + grade); /* = Print */
        Debug.Log("speed : " + speed);
        Debug.Log("direction : " + direction);
    }

    public void Update() /* �� ������ ȣ�� */
    {

        Debug.Log("Update");
    }

}
