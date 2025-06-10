using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//컨트롤 + a = 모두 선택
//컨트롤 + k + d = 줄 정리

public class IF_First : MonoBehaviour
{
    // for(int 반복에 사용하는 변수 (예시 i) = 0(변수 값 초기화); 반복에 사용하는 변수 < 100(반복 하는 조건 / 현재는 100미만 번 반복 즉, 0~99번 반복); 반복에 사용하는 변수 ++(증가값 / 현재는  1씩 증가))
    // 우리는 for문을 보편적으로 특정 횟수만큼 반복하는 것에 사용하기 때문에
    // for(int i = 0; i < 10; i++) // 0부터 9까지 반복하는 for문
    // for(int i = 0; i <=9; i++) // 0부터 9까지 반복하는 for문
    // for int i = 10; i > 0; i--) // 10부터 1까지 반복하는 for문
    private void Awake()
    {
        count = 0; // 초기화
    }

    int count;


   // void Start()
    //{
      //  for(int i = 0; i < 5; i++)
       // {
       //     Debug.Log("반복문이 실행되었어요.");
       // }

        // i = 0 , 0 < 5
       // Debug.Log("반복군이 실행되었어요.");
        // i ++

        // i = 1 여전히 5보다 작다.
        //Debug.Log("반복군이 실행되었어요.");
        // i ++

        // i = 2 여전히 5보다 작다.
        //Debug.Log("반복군이 실행되었어요.");
        // i ++

        // i = 3 여전히 5보다 작다.
        //Debug.Log("반복군이 실행되었어요.");
        // i ++

        // i = 4 여전히 5보다 작다.
        //Debug.Log("반복군이 실행되었어요.");
        // i ++

        // i = 5 이제 5보다 작지 않다.
        // Debug.Log("반복군이 실행되었어요."); 가 나오지 않고 반복문이 종료된다.
    //}


    void Start()//private이 생략되어있는 것이다.
    {
    }

    public void Gacha()
    {
        int randomValue = Random.Range(1, 101); // 1부터 100까지의 랜덤한 정수값을 반환합니다.
        Debug.Log($"랜덤한 값은 : {randomValue}입니다.");
        int number = 0;

        while (number < 10)
        {
            if (8 <= count)
            {
                count = 0; //초기화
                Debug.Log("확정! '각청'을 뽑았다!");
            }
            else if (randomValue <= 10)//=>해당 함수가 10%를 의미 // 10%확률인 경우에는 // 1~10
            {
                Debug.Log("'각청'을 뽑았다!");
            }
            else if (randomValue <= 30)// => 해당 함수가 20% 위에서 10%를 걸러졌기 때문에 20%를 의미한다. // 20%확률인 경우에는 // 11~30
            {
                Debug.Log("'모나'를 뽑았다!");
            }
            else if (randomValue <= 60)
            {
                Debug.Log("'그 녀석'을 뽑았다!");
            }
            else // 그 이외의 경우에는
            {
                Debug.Log("'치치'를 뽑아버렸다!");
            }
            count++; // 카운트 증가
            number++;
        }



        //확률이 10%인 경우 로그에 '각청'을 뽑았다!
        // 확률이 20%면 로그에 '모나'를 뽑았다!
        // 그 이외의 경우에는 치치 '치치'를 뽑아버렸다!



        //for (int i = 0; i < 10; i++) // for 하고 텝키 누르면 자동으로 반복문이 생성된다.
        //{

            //if (8 <= count)
            //{
              //  count = 0; //초기화
             //   Debug.Log("확정! '각청'을 뽑았다!");
            //}
            //else if (randomValue <= 10)//=>해당 함수가 10%를 의미 // 10%확률인 경우에는 // 1~10
            //{
             //   Debug.Log("'각청'을 뽑았다!");
            //}
            //else if (randomValue <= 30)// => 해당 함수가 20% 위에서 10%를 걸러졌기 때문에 20%를 의미한다. // 20%확률인 경우에는 // 11~30
            //{
            //    Debug.Log("'모나'를 뽑았다!");
           // }
            //else if (randomValue <= 60)
           // {
             //   Debug.Log("'그 녀석'을 뽑았다!");
            //}
            //else // 그 이외의 경우에는
           // {
              //  Debug.Log("'치치'를 뽑아버렸다!");
            //}
          //  count++; // 카운트 증가
        //}

    }

   
    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe) //0
            // switch를 입력하고 텝  키를 누르면 자동으로 생성된다.
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // 픽업 캐릭 : 이번 뽑기에 확률이 높게  설정되는 캐릭터
                        // 유저들이 특정 캐릭터를 목표하고 뽑게 만드는 시스템
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 2:
                // 분홍 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'분홍 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            default:
                // 파란 머리 꼬마 캐릭터가 나온다.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리 꼬마'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;
        }
    }


    void Update()
    {
    }
}
