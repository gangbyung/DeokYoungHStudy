using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[접근지정자] [데이터 타입] [클래스명]
class AnimalClassDemo
{

    public string Name;//필드- an 클래스 변수
    public string Color; 


}
public class BacePlayer : MonoBehaviour
{
    //이동, 점프, 공격, 회피, 상호작용, 대수ㅏ
    //원하는 기능을 전부 분리해서 만

    private void Start()
    {
        AnimalClassDemo animal = new AnimalClassDemo();
        animal.Name = "고양이";
        animal.Color = "강아지";

        Debug.Log($"{animal.Name}{animal.Color}");
    }
    
}
