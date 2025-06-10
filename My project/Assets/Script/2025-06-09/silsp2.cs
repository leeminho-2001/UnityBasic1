using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class silsp2 : MonoBehaviour
{

    public TextMeshProUGUI Txt_Pilot;

    string[] character = { "아무로 레이", "카미유 비단", "쥬도 아시타", "하사웨이 노아", "버나지 링크스","샤아 아즈나블" };
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
        
        Debug.Log(character[randomValue] + "라고 입니다.");
        Txt_Pilot.text = character[randomValue];
    }
 
    public void PilotListGacha() // characterList.Count // 요게 안됩니당
    {
        int randomValue = Random.Range(0, characterList.Count);  // 6 , 0 ~ 5
        Txt_Pilot.text = characterList[randomValue];
    }

    public void AddPilotList()
    {
        // character 배열에는 파일럿 이름이 있습니다.
        // characterList에는 아무 데이터도 없습니다.
        // character 배열의 데이터를 charcterList에다가 넣어주는 식을 만들어봅시다.
        // 우리가 배운 반복문을 사용해서 만들어 봅시다.
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
        Txt_Pilot.text = string.Empty; // 초기화

        while (number < 10)
        {
            int randomValue = Random.Range(1, 101);

            if (Count >= 7)
            {             
                Count = 0;
                Debug.Log("'확정'" + "아무로 레이 획득!");
                Txt_Pilot.text += "아무로 레이";
            }
            else if (randomValue <= 5)
            {
                Debug.Log("아무로 레이");
                Txt_Pilot.text += "아무로 레이";
            }
            else if (randomValue <= 10)
            {
                Debug.Log("샤아 아즈나블");
                Txt_Pilot.text += "샤아 아즈나블";
            }
            else if (randomValue <= 15)
            {
                Debug.Log("카미유 비단");
                Txt_Pilot.text += "카미유 비단";
            }
            else if (randomValue <= 20)
            {
                Debug.Log("쥬도 아시타");
                Txt_Pilot.text += "쥬도 아시타";
            }
            else if (randomValue <= 25)
            {
                Debug.Log("하사웨이 노아");
                Txt_Pilot.text += "하사웨이 노아";
            }
            else
            {
                Debug.Log("버나지 링크스");
                Txt_Pilot.text += "버나지 링크스";
            }
            
            number++;
            Count++;
        }
    }
  
}

