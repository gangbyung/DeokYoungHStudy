using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootDeom : MonoBehaviour
{
    public class Stuff //�ϳ��� Ʋ�� ���� ����ϱ� ���� ����
    {
        public int bullets;

        public Stuff() { } //�⺻������
        public Stuff(int _bul) //������
        {
            bullets = _bul;
        }
    }
    public Rigidbody bulletPrefab;
    public Transform firePos;
    public Stuff mystuff = new Stuff(10);
    private void Update()
    {
        Shoot();
    }
    void Shoot() //�߻�
    {
        if (Input.GetButtonDown("Fire1") && mystuff.bullets > 0)
        {
            Rigidbody bulletlnstace = Instantiate(bulletPrefab, firePos.position, firePos.rotation) as Rigidbody;
            bulletlnstace.AddForce(firePos.forward * 1000);
            mystuff.bullets--;
        }
    }
}
