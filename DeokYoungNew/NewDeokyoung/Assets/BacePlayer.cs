using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[����������] [������ Ÿ��] [Ŭ������]
class AnimalClassDemo
{

    public string Name;//�ʵ�- an Ŭ���� ����
    public string Color; 


}
public class BacePlayer : MonoBehaviour
{
    //�̵�, ����, ����, ȸ��, ��ȣ�ۿ�, �����
    //���ϴ� ����� ���� �и��ؼ� ��

    private void Start()
    {
        AnimalClassDemo animal = new AnimalClassDemo();
        animal.Name = "�����";
        animal.Color = "������";

        Debug.Log($"{animal.Name}{animal.Color}");
    }
    
}
