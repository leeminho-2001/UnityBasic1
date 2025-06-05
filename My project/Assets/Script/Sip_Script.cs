using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sip_Script : MonoBehaviour
{

    private string Name = "이민호";
    private int MyAge = 25;
    private float Stature = 155.8f; // float는 실수형 변수로, 소수점 이하를 포함할 수 있다.
    private string MBTI = "INFJ";
    private string Targer_Occupation = "시나리오 기획자";
    private string Dream = "내가 죽은 뒤에도 회자되는 대명작을 만드는 것";
    private string Favorite_Thing = "게임, 그림, 집필";
    private string Favorite_Food = "감자튀김";
    private int My_Score = Random.Range(1, 101);
    private string Favorite_Work = "Fate Stay Night";


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("키? 키요?" + " ...으음" + "제 키는" + Stature + "cm입니다.");
        Debug.Log($"키? 키요? ...으음 제 키는 {Stature}cm입니다.");
        Debug.Log("크흠, 주제를 바꾸죠!");
        Debug.Log("꿈말이죠." + "제 꿈은" + Dream + "입니다!");
        Debug.Log($"꿈말이죠. 제 꿈은 {Dream}입니다!");
        Debug.Log("어..." + "좋아하는 음식은 뭔가요?" + "저는 " + Favorite_Food + "을 좋아합니다!");
        Debug.Log($"어... 좋아하는 음식은 뭔가요? 저는 {Favorite_Food}을 좋아합니다!");
        Debug.Log("으음...취미!" + "저의 취미는" + Favorite_Thing + "입니다.");
        Debug.Log($"으음...취미! 저의 취미는 {Favorite_Thing}입니다.");
        Debug.Log("장래희망은 " + Targer_Occupation + "입니다!");
        Debug.Log($"장래희망은 {Targer_Occupation}입니다!");
        Debug.Log("좋아하는 작품은 " + Favorite_Work + "입니다!");
        Debug.Log($"좋아하는 작품은 {Favorite_Work}입니다!");

        //Debug.Log("Start 함수입니다.한번 만 실행됩니다.");
    }

    void Awake()
    {
        Debug.Log("안녕하세요? " + "저의 이름은 " + Name + "입니다.");
        Debug.Log($"안녕하세요? 저의 이름은 {Name}입니다.");
        //Debug.Log("Awake 함수입니다. 최초 한번만 실행됩니다.");
    }

    private void OnEnable()
    {
        Debug.Log("나이는 " + MyAge + "살 입니다.");
        Debug.Log($"나이는 {MyAge}살 입니다.");
        Debug.Log("MBTI는..." + MBTI + "입니다.");
        Debug.Log($"MBTI는...{MBTI}입니다!");
        Debug.Log("저는 저 스스로에게 주는 점수가 있습니다.");
        //Debug.Log("OneEnable 함수입니다. 활성화 될 때 실행됩니다.");
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("그때 그때 바뀝니다만, 제게 주는 제 점수는 " + My_Score + "점입니다");
        Debug.Log($"그때 그때 바뀝니다만, 제게 주는 제 점수는 {My_Score}점입니다.");

        //Debug.Log("Update 함수입니다. 매 프레임마다 실행됩니다.");
    }





}
