using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootDeom : MonoBehaviour
{
    public class Stuff //하나의 틀을 만들어서 사용하기 위해 정의
    {
        public int bullets;

        public Stuff() { } //기본생성자
        public Stuff(int _bul) //생성자
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
    void Shoot() //발사
    {
        if (Input.GetButtonDown("Fire1") && mystuff.bullets > 0)
        {
            Rigidbody bulletlnstace = Instantiate(bulletPrefab, firePos.position, firePos.rotation) as Rigidbody;
            bulletlnstace.AddForce(firePos.forward * 1000);
            mystuff.bullets--;
        }
    }
}
