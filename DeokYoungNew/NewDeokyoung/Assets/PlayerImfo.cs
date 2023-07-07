using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Six
{   
    //정적
    public class GlobalScore
    {
        //프로그램 전체에서 하나만 존재 해야 합니다.
        //전체 프로그램에서 공유해야하는 변수가 있다면 정적으로 필드를 사용하는게 좋습니다.
        public static int Score = 0; //정적 필드생성 정적(static)
    }
    public class PlayerState
    {
        //필드작성
        public int HP;
        public int MP;
        public string PlayerName;
        
        //생성자
        //기본 생성자
        public PlayerState() //() 생성자 의미
        {
            HP = 100;
            MP = 100;
            PlayerName = "언노운";
        }
        public PlayerState(int _HP, int _MP, string _name) //생성자
        {
            HP = _HP;
            MP = _MP;
            PlayerName = _name;
        }

        //메소드 작성
        public void ViewllNFO()
        {
            GlobalScore.Score++;

            Debug.Log($"{HP},{MP},{PlayerName}");
        }
    }

    public class PlayerDeepState
    {
        public int HP;
        public int MP;

        public PlayerDeepState DeepCopy()//메소드 클래스 함수
        {
            PlayerDeepState newCopy = new PlayerDeepState();
            newCopy.HP = this.HP;
            newCopy.MP = this.MP;
            return newCopy;
        }
    }
    public class PlayerImfo : MonoBehaviour
    {
        private void Start()
        {
            PlayerState player0 = new PlayerState();
            player0.ViewllNFO();

            PlayerState player1 = new PlayerState();//인스턴스화 객체생성
            player1.HP = 100;
            player1.MP = 50;
            player1.PlayerName = "나_전사";

            Debug.Log($"{player1.HP},{player1.MP},{player1.PlayerName}");

            player1.ViewllNFO();//메소드를 호출하여 사용합니다.

            PlayerState player2 = new PlayerState();
            player2.HP = 50;
            player2.MP = 100;
            player2.PlayerName = "나_법사";

            player2.ViewllNFO();

            //스포너 ?랜덤캐릭 셀렉
            PlayerState Hero = new PlayerState(500, 500, "영웅등장");
            Hero.ViewllNFO();

            Debug.Log($"{GlobalScore.Score}");

            //-----------------------------------//
            //앝은복사 깊은복사

            PlayerState SampleA = new PlayerState();
            SampleA.HP = 100;
            SampleA.MP = 200;

            PlayerState SampleB = SampleA;
            SampleB.MP = 500;

            Debug.Log($"{SampleA.HP} {SampleA.MP}");
            Debug.Log($"{SampleB.HP} {SampleB.MP}");

            //깊은 복사 과정
            PlayerDeepState SampleDA = new PlayerDeepState();
            SampleDA.HP = 100;
            SampleDA.MP = 200;

            PlayerDeepState SampleDB = SampleDA.DeepCopy();
            SampleDB.MP = 500;

            Debug.Log($"{SampleDA.HP} {SampleDA.MP}");
            Debug.Log($"{SampleDB.HP} {SampleDB.MP}");
        }
    }
}