using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Test : MonoBehaviour // MonoBehaviour�� ����Ƽ���� �����ϱ� ���� �پ��ִ� ģ���̴�.
{
    // Start is called before the first frame update


    void Awake()
    {
        Debug.Log("Awake �Լ��Դϴ�. ���� �ѹ��� ����˴ϴ�.");
    }


    //private void OnEnable()
    //{
    //  Debug.Log("OneEnable �Լ��Դϴ�. Ȱ��ȭ �� �� ����˴ϴ�.");
    //}

    //void Start()
    //{
    //   Debug.Log("Start �Լ��Դϴ�.�ѹ� �� ����˴ϴ�.");
    //}

    //int platerLevel = 10;
  //  new string name;
   // private void Start()
    //{
      //  name += "���� �̸���";
        //name += "��ö��";
        //name += "�Դϴ�.";

        //Debug.Log(name);

//        Debug.Log("���� ������" + platerLevel + "�Դϴ�.");
  //      Debug.Log($"���� ������ {platerLevel}�Դϴ�.");
    //}


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update �Լ��Դϴ�. �� �����Ӹ��� ����˴ϴ�.");
    }

    //int Sum (int value1, int value2)// int�� �̿��� ���ϱ� �Լ�
    //return Sum(value1 + value2);// Sum �Լ��� �� ���� ������ �޾Ƽ� �� ���� ��ȯ�Ѵ�.


    //����
    //1byt = 8bit
    //4byt = 32bit
    // ��, 4����Ʈ�� 01�� �̷���� 2������ 32���� �ִٴ� ������ 2�� 32���̴�.
    // 2�� 32��(2^32)�� �� 42���̴�.
    // ������ ��Ʈ�� ������ -2,147,483,648`(-21��)���� `2,147,483,647`(21��)�����̴�.


    //void OnEnable()
    //{
        // Random.InitState(1);-- �õ� ���� �����ϴ� ������ ���� ���ڷ� �����ȴ�.
        //Debug.Log(Random.Range(1, 100));
        // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
    //}
}
//�츮�� �˾ƾ��ϴ� �ڵ�� ����Ƽ C# ��ũ��Ʈ ���� -1 ������ �ִ�.

//-�츮�� Player�� Level�� ����Ͽ� Monster�� Level�� ��������� �մϴ�.
//- Monster�� playerLevel�� �������� ���ϸ鼭, ������ ���޹޴� ����� ������ �������?
//- �پ��� ����� ������, ���� ��� �Լ�, ����, ���� �����ڸ����� �����غ��ô�.
