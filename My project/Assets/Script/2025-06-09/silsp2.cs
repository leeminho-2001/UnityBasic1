using System.Collections;
using System.Collections.Generic;
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

  
}

