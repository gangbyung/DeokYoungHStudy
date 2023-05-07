using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ʹϾ��� �Ұ� ����. ��ü�� ȸ���� ���ʹϾ��� ���ؼ� �����ϱ⶧���� ������Ʈ Rotaion���� vector3�� �����ϴ°�ó�� ��������
/// ���ʹϾ����� �����ϰ� vector3�ΰ�ó�� �������ϴ°� ����Ƽ���� ������ ������ �������ְ��ִ�.
/// </summary>
public class QuaternionDemo : MonoBehaviour
{
    public float DemoFloat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetQuaternionEuler();
    }
    void SetQuaternionEuler()
    {
        //���� ���ʹϾ��� 4������ ��� �����̴�. �׷��� �Ʒ�ó�� �츮�� Vector3 �����ϵ��� �ϰԵȴٸ� ������ ���Ե�
        //transform.rotation = new Vector3(30, 1, 1); 

        ///Vector3�� ���ʹϾ����� �����ϴ¹�
        /// Quaternion.Euler(Vector3)
        /// Vector3�� �Ű������� �Ѱ� �޾� �� vector3�� ���ʹϾ� ������ Ÿ������ ��ȯ�� ���Ͻ����ִ� �Լ��̴�.
        /// Euler�� 3���� ���ͷ� ������ ȸ���� ǥ�� �� �� �ֵ�����.
        //1.
        // transform.rotation = Quaternion.Euler(new Vector3(30, 30, 30)*Time.time); //Rotation���� 30,30,30�� ��
        //var T = 30;
        //Debug.Log(T * Time.time);


        ///LookRotation�Լ�
        /// ���͸� �Ű��Ǽ��� �־��ָ� �� ������Ʈ�� �Ű����� ������ ó�ٺ��Բ� �ڱ� �ڽ��� ������ ȸ����.
        //2. �ᱹ Ÿ���� ��� �ٶ󺸰� �� �� ����
        var item = GameObject.Find("Target").GetComponent<Transform>();
        //transform.rotation = Quaternion.LookRotation(new Vector3(1, 0, 0));
        //transform.rotation = Quaternion.LookRotation(item.position);
        //�� ������ ���ݴ� ���캸�ڸ� ������ ������ ������ �ִ�.
        // ������ ��ġ - �������� ��ġ = ���������� ����� �Ÿ� ���� �� �����Եȴ�.

        //Lerp
        //�ΰ��� ȸ�� ���� ���ϸ� �� �߰��� ������ ȸ�� ���� ������.
        /*
       Quaternion aRotation = Quaternion.Euler(new Vector3(0, 30, 0)); //�ܼ��ϰ� ȸ���� ��Ű�� �ڵ�
       Quaternion bRotation = Quaternion.Euler(new Vector3(0, 90, 0));

       Quaternion taregetRotation = Quaternion.Lerp(aRotation, bRotation, DemoFloat); //���� f���� 0.5��� �߰� 1�̸� b 0�̸� a, 0.2 �� a�� ���ݴ� ������
       transform.rotation = taregetRotation;
   */
    
    }
}
