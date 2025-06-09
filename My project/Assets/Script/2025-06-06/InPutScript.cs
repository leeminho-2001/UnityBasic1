using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InPutScript : MonoBehaviour
{


    public TextMeshProUGUI Txt_Text; // 텍스트를 넣을 곳
    // 어디 텍스트를 가지고 올지 
    [SerializeField] TMP_InputField Input_Text;


    public void OnClickButton()
    {
        Txt_Text.text = Input_Text.text;
    }

}
