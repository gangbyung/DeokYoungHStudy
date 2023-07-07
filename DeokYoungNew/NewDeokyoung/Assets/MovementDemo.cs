using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDemo : MonoBehaviour
{
    
    
    //필드
    public float speed; //앞뒤 움직이는 값을 조절하는 필드
    public float turnSpeed; //회전하는 속도값

    public Rigidbody bulletPrefab;
    public Transform firePos;
    private void Update()
    {
        Movement();
        
    }

    void Movement() //움직임
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        //이동결과 적용
        transform.Translate(Vector3.forward * forwardMovement);
        //회전결과 적용
        transform.Rotate(Vector3.up * turnMovement);
    }
    
}
