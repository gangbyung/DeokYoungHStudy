using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Six
{   
    //����
    public class GlobalScore
    {
        //���α׷� ��ü���� �ϳ��� ���� �ؾ� �մϴ�.
        //��ü ���α׷����� �����ؾ��ϴ� ������ �ִٸ� �������� �ʵ带 ����ϴ°� �����ϴ�.
        public static int Score = 0; //���� �ʵ���� ����(static)
    }
    public class PlayerState
    {
        //�ʵ��ۼ�
        public int HP;
        public int MP;
        public string PlayerName;
        
        //������
        //�⺻ ������
        public PlayerState() //() ������ �ǹ�
        {
            HP = 100;
            MP = 100;
            PlayerName = "����";
        }
        public PlayerState(int _HP, int _MP, string _name) //������
        {
            HP = _HP;
            MP = _MP;
            PlayerName = _name;
        }

        //�޼ҵ� �ۼ�
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

        public PlayerDeepState DeepCopy()//�޼ҵ� Ŭ���� �Լ�
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

            PlayerState player1 = new PlayerState();//�ν��Ͻ�ȭ ��ü����
            player1.HP = 100;
            player1.MP = 50;
            player1.PlayerName = "��_����";

            Debug.Log($"{player1.HP},{player1.MP},{player1.PlayerName}");

            player1.ViewllNFO();//�޼ҵ带 ȣ���Ͽ� ����մϴ�.

            PlayerState player2 = new PlayerState();
            player2.HP = 50;
            player2.MP = 100;
            player2.PlayerName = "��_����";

            player2.ViewllNFO();

            //������ ?����ĳ�� ����
            PlayerState Hero = new PlayerState(500, 500, "��������");
            Hero.ViewllNFO();

            Debug.Log($"{GlobalScore.Score}");

            //-----------------------------------//
            //�������� ��������

            PlayerState SampleA = new PlayerState();
            SampleA.HP = 100;
            SampleA.MP = 200;

            PlayerState SampleB = SampleA;
            SampleB.MP = 500;

            Debug.Log($"{SampleA.HP} {SampleA.MP}");
            Debug.Log($"{SampleB.HP} {SampleB.MP}");

            //���� ���� ����
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