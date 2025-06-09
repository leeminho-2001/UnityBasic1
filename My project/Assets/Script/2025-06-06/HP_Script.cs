using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HP_Script : MonoBehaviour
{
    public Image img_HPbar; // 이미지를 정할 때 유니티 엔진 UI로 설정해야한다.
    [SerializeField] TextMeshProUGUI Txt_HP;

    public TextMeshProUGUI Txt_Text; // 데미지를 받았다는 텍스트를 넣을 곳
    public int MaxHP;
    int nowHP;
    // 최소체력은 0

    public int Damage;
    public int HealPoint;
    

    private void Awake()
    {
        nowHP = MaxHP;
        Inutuakuze();
    }

    public void OnClickDamage()
    {
        Damage = Random.Range(5, 100);

        nowHP -= Damage; // 데미지를 받는다.
        if (nowHP < 0) // 그런데 0보다 낮아지면 0으로 고정한다.
        { 
            nowHP = 0;
            
        }

        if (Damage > 50)

        {
            Txt_Text.text = $"{Damage}의 데미지를 받았습니다! (크리티컬!)";
            // 데미지를 받았다는 텍스트를 출력한다. 크리티컬이 뜨는 텍스트
        }
        else
        { 
            Txt_Text.text = $"{Damage}의 데미지를 받았습니다.";
            // 데미지를 받았다는 텍스트를 출력한다.
        }


        RefreshUI();
    }

    void Inutuakuze() // 임의의 이름을 정한다.
    {
        RefreshUI(); // UI를 갱신한다.
    }

    public void OnClickHeal() // 힐을 받는다.
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {  
            nowHP = MaxHP;
        }
        
        RefreshUI();
    }

    void RefreshUI()//갱신하고 다시
    { 
        img_HPbar.fillAmount = (float)nowHP / MaxHP; // 현재 체력/최대 체력
         // '/'가 인트로 적용되어 있기 때문에 float으로 바꿔져야한다. float은 소수점까지 적용되는 함수
         // 인트끼리 붙으면 정수만 나오기 때문에 1,0만이 나온다.
        Txt_HP.text = $"{nowHP} / {MaxHP}";
    }

}
