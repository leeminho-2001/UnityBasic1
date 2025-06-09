using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HP_Script : MonoBehaviour
{
    public Image img_HPbar; // �̹����� ���� �� ����Ƽ ���� UI�� �����ؾ��Ѵ�.
    [SerializeField] TextMeshProUGUI Txt_HP;

    public TextMeshProUGUI Txt_Text; // �������� �޾Ҵٴ� �ؽ�Ʈ�� ���� ��
    public int MaxHP;
    int nowHP;
    // �ּ�ü���� 0

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

        nowHP -= Damage; // �������� �޴´�.
        if (nowHP < 0) // �׷��� 0���� �������� 0���� �����Ѵ�.
        { 
            nowHP = 0;
            
        }

        if (Damage > 50)

        {
            Txt_Text.text = $"{Damage}�� �������� �޾ҽ��ϴ�! (ũ��Ƽ��!)";
            // �������� �޾Ҵٴ� �ؽ�Ʈ�� ����Ѵ�. ũ��Ƽ���� �ߴ� �ؽ�Ʈ
        }
        else
        { 
            Txt_Text.text = $"{Damage}�� �������� �޾ҽ��ϴ�.";
            // �������� �޾Ҵٴ� �ؽ�Ʈ�� ����Ѵ�.
        }


        RefreshUI();
    }

    void Inutuakuze() // ������ �̸��� ���Ѵ�.
    {
        RefreshUI(); // UI�� �����Ѵ�.
    }

    public void OnClickHeal() // ���� �޴´�.
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {  
            nowHP = MaxHP;
        }
        
        RefreshUI();
    }

    void RefreshUI()//�����ϰ� �ٽ�
    { 
        img_HPbar.fillAmount = (float)nowHP / MaxHP; // ���� ü��/�ִ� ü��
         // '/'�� ��Ʈ�� ����Ǿ� �ֱ� ������ float���� �ٲ������Ѵ�. float�� �Ҽ������� ����Ǵ� �Լ�
         // ��Ʈ���� ������ ������ ������ ������ 1,0���� ���´�.
        Txt_HP.text = $"{nowHP} / {MaxHP}";
    }

}
