using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InPutScript : MonoBehaviour
{


    public TextMeshProUGUI Txt_Text; // �ؽ�Ʈ�� ���� ��
    // ��� �ؽ�Ʈ�� ������ ���� 
    [SerializeField] TMP_InputField Input_Text;


    public void OnClickButton()
    {
        Txt_Text.text = Input_Text.text;
    }

}
