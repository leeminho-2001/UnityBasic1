using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Star : MonoBehaviour
{

    //F10을 누르면 코드가 하나 씩 진행되는 과정을 볼 수 있다.
    // 종료하고 싶으면 F5를 누르면 된다.

    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    int i;
    public void Phase1()
    {
        star = string.Empty; // Empy는 빈 문자열을 의미합니다. 스타를 초기화하는 용도로 사용합니다. 이걸 사용하지 않으면 이전 페이즈의 문자열이 남아있을 수 있습니다.

        // 페이즈 1
        /*for (int i = 1; i < 6; i++) // 0부터 5까지 반복
        {
            for (int j = 1; j <= i; j++)
            {
                star += "★"; // 별
            }
            star += "\n"; // 줄바꿈
        }*/

        for (int i = 1; i < 6; i++) // 0부터 5까지 반복
        {
            for (int j = 1; j <= i; j++)
            {
                star += "★"; // 별
            }
            star += "\n"; // 줄바꿈
        }
            Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2

        /*for (int i = 1; i < 6; i++) // 0부터 5까지 반복
        {
            for (int q = 5; q > i; q--) // 6부터 i까지 반복
            {
                star += "　"; // 공백
            }
            for (int j = 0; j < i; j++)
            {
                star += "★"; // 별
            }
            star += "\n"; // 줄바꿈
        }
        Debug.Log(star);\*/

        for (int i = 1; i < 6; i++)
        {
            for (int q = 1; q < i; q++)
            {
                star += "　"; // 공백
            }
            for (int j = 6; j > i; j--)
            {
                star += "★"; // 별
            }

            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3

        for (int i = 1; i < 6; i++) // 0부터 5까지 반복
        {
            for (int j = 1; j <= i; j++)
            {
                star += "★"; // 별
            }
            star += "\n"; // 줄바꿈
            if (i >= 5)
            {
                for (int w = 5; w < 10; w++)
                {
                    for (int q = 9; q > w; q--) // 6부터 i까지 반복
                    {
                        star += "★"; // 별
                    }
                    star += "\n"; // 줄바꿈
                }
            }
        }


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4
        for (int i = 1; i < 6; i++) // 0부터 5까지 반복
        {
            for (int q = 5; q > i; q--) // 6부터 i까지 반복
            {
                star += "　"; // 공백
            }
            for (int j = 0; j < i; j++)
            {
                star += "★"; // 별
            }
            star += "\n"; // 줄바꿈

            if (i >= 5)
            {
                for (int w = 5; w < 10; w++)
                {
                    for (int e = 4; e < w; e++) // 6부터 i까지 반복
                    {
                        star += "　"; // 공백
                    }
                    for (int r = 9; r > w; r--)
                    {
                        star += "★"; // 별
                    }
                    star += "\n"; // 줄바꿈
                }
            }


        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        // 페이즈 5
        star = string.Empty;

        for (int i = 1; i < 6; i++) // 0부터 5까지 반복
        {
            for (int q = 5; q > i; q--) // 6부터 i까지 반복
            {
                star += "　"; // 공백
            }
            for (int j = 0; j < i * 2 - 1; j++)
            {
                star += "★"; // 별
            }

            star += "\n"; // 줄바꿈

            if (i >= 5)
                for (int w = 5; w < 10; w++)
                {
                    for (int e = 4; e < w; e++) // 6부터 i까지 반복
                    {
                        star += "　"; // 공백
                    }
                    for (int r = 9; r > w; r--)
                    {
                        star += "★"; // 별
                    }
                    star += "\n"; // 줄바꿈
                }


        }
        Debug.Log(star);
    }
}