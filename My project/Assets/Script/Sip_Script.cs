using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sip_Script : MonoBehaviour
{

    private string Name = "�̹�ȣ";
    private int MyAge = 25;
    private float Stature = 155.8f; // float�� �Ǽ��� ������, �Ҽ��� ���ϸ� ������ �� �ִ�.
    private string MBTI = "INFJ";
    private string Targer_Occupation = "�ó����� ��ȹ��";
    private string Dream = "���� ���� �ڿ��� ȸ�ڵǴ� ������� ����� ��";
    private string Favorite_Thing = "����, �׸�, ����";
    private string Favorite_Food = "����Ƣ��";
    private int My_Score = Random.Range(1, 101);
    private string Favorite_Work = "Fate Stay Night";


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ű? Ű��?" + " ...����" + "�� Ű��" + Stature + "cm�Դϴ�.");
        Debug.Log($"Ű? Ű��? ...���� �� Ű�� {Stature}cm�Դϴ�.");
        Debug.Log("ũ��, ������ �ٲ���!");
        Debug.Log("�޸�����." + "�� ����" + Dream + "�Դϴ�!");
        Debug.Log($"�޸�����. �� ���� {Dream}�Դϴ�!");
        Debug.Log("��..." + "�����ϴ� ������ ������?" + "���� " + Favorite_Food + "�� �����մϴ�!");
        Debug.Log($"��... �����ϴ� ������ ������? ���� {Favorite_Food}�� �����մϴ�!");
        Debug.Log("����...���!" + "���� ��̴�" + Favorite_Thing + "�Դϴ�.");
        Debug.Log($"����...���! ���� ��̴� {Favorite_Thing}�Դϴ�.");
        Debug.Log("�巡����� " + Targer_Occupation + "�Դϴ�!");
        Debug.Log($"�巡����� {Targer_Occupation}�Դϴ�!");
        Debug.Log("�����ϴ� ��ǰ�� " + Favorite_Work + "�Դϴ�!");
        Debug.Log($"�����ϴ� ��ǰ�� {Favorite_Work}�Դϴ�!");

        //Debug.Log("Start �Լ��Դϴ�.�ѹ� �� ����˴ϴ�.");
    }

    void Awake()
    {
        Debug.Log("�ȳ��ϼ���? " + "���� �̸��� " + Name + "�Դϴ�.");
        Debug.Log($"�ȳ��ϼ���? ���� �̸��� {Name}�Դϴ�.");
        //Debug.Log("Awake �Լ��Դϴ�. ���� �ѹ��� ����˴ϴ�.");
    }

    private void OnEnable()
    {
        Debug.Log("���̴� " + MyAge + "�� �Դϴ�.");
        Debug.Log($"���̴� {MyAge}�� �Դϴ�.");
        Debug.Log("MBTI��..." + MBTI + "�Դϴ�.");
        Debug.Log($"MBTI��...{MBTI}�Դϴ�!");
        Debug.Log("���� �� �����ο��� �ִ� ������ �ֽ��ϴ�.");
        //Debug.Log("OneEnable �Լ��Դϴ�. Ȱ��ȭ �� �� ����˴ϴ�.");
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("�׶� �׶� �ٲ�ϴٸ�, ���� �ִ� �� ������ " + My_Score + "���Դϴ�");
        Debug.Log($"�׶� �׶� �ٲ�ϴٸ�, ���� �ִ� �� ������ {My_Score}���Դϴ�.");

        //Debug.Log("Update �Լ��Դϴ�. �� �����Ӹ��� ����˴ϴ�.");
    }





}
