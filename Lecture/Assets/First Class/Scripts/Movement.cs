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
    
    private void Start() /* 오브젝트 생성 직후 단 한 번 호출 */
    {
        Debug.Log("grade : " + grade); /* = Print */
        Debug.Log("speed : " + speed);
        Debug.Log("direction : " + direction);
    }

    public void Update() /* 매 프레임 호출 */
    {

        Debug.Log("Update");
    }

}
