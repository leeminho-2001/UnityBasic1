using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class silsp2 : MonoBehaviour
{

    public TextMeshProUGUI Txt_Pilot;

    string[] character = { "�ƹ��� ����", "ī���� ���", "�굵 �ƽ�Ÿ", "�ϻ���� ���", "������ ��ũ��","���� �����" };
    List<string> characterList = new List<string> ();

    void Start()
    {
    for (int i = 0; i < character.Length; i++) // i < 6 -> 0 ~ 5
        {
            characterList.Add(character[i]);
        }
    }

    public void PilotGacha() // character.Length
    {
        int randomValue = Random.Range(0, character.Length); // 6 , 0 ~ 5
        
        Debug.Log(character[randomValue] + "��� �Դϴ�.");
        Txt_Pilot.text = character[randomValue];
    }
 
    public void PilotListGacha() // characterList.Count // ��� �ȵ˴ϴ�
    {
        int randomValue = Random.Range(0, characterList.Count);  // 6 , 0 ~ 5
        Txt_Pilot.text = characterList[randomValue];
    }

    public void AddPilotList()
    {
        // character �迭���� ���Ϸ� �̸��� �ֽ��ϴ�.
        // characterList���� �ƹ� �����͵� �����ϴ�.
        // character �迭�� �����͸� charcterList���ٰ� �־��ִ� ���� �����ô�.
        // �츮�� ��� �ݺ����� ����ؼ� ����� ���ô�.
        for (int i = 0; i < character.Length; i++) // i < 6 -> 0 ~ 5
        {
            characterList.Add(character[i]);
        }
        for (int i = 0; i < characterList.Count; i++)
        {
            Debug.Log(characterList[i]);
        }
    }

    public void Awake()
    {
        Count = 0;
    }

    int Count;
    public void Gacha()
    {
    
        int number = 0;
        Txt_Pilot.text = string.Empty; // �ʱ�ȭ

        while (number < 10)
        {
            int randomValue = Random.Range(1, 101);

            if (Count >= 7)
            {             
                Count = 0;
                Debug.Log("'Ȯ��'" + "�ƹ��� ���� ȹ��!");
                Txt_Pilot.text += "�ƹ��� ����";
            }
            else if (randomValue <= 5)
            {
                Debug.Log("�ƹ��� ����");
                Txt_Pilot.text += "�ƹ��� ����";
            }
            else if (randomValue <= 10)
            {
                Debug.Log("���� �����");
                Txt_Pilot.text += "���� �����";
            }
            else if (randomValue <= 15)
            {
                Debug.Log("ī���� ���");
                Txt_Pilot.text += "ī���� ���";
            }
            else if (randomValue <= 20)
            {
                Debug.Log("�굵 �ƽ�Ÿ");
                Txt_Pilot.text += "�굵 �ƽ�Ÿ";
            }
            else if (randomValue <= 25)
            {
                Debug.Log("�ϻ���� ���");
                Txt_Pilot.text += "�ϻ���� ���";
            }
            else
            {
                Debug.Log("������ ��ũ��");
                Txt_Pilot.text += "������ ��ũ��";
            }
            
            number++;
            Count++;
        }
    }
  
}

