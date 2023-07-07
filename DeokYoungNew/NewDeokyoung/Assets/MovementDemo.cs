using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDemo : MonoBehaviour
{
    
    
    //�ʵ�
    public float speed; //�յ� �����̴� ���� �����ϴ� �ʵ�
    public float turnSpeed; //ȸ���ϴ� �ӵ���

    public Rigidbody bulletPrefab;
    public Transform firePos;
    private void Update()
    {
        Movement();
        
    }

    void Movement() //������
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        //�̵���� ����
        transform.Translate(Vector3.forward * forwardMovement);
        //ȸ����� ����
        transform.Rotate(Vector3.up * turnMovement);
    }
    
}
