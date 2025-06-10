using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Star : MonoBehaviour
{

    //F10�� ������ �ڵ尡 �ϳ� �� ����Ǵ� ������ �� �� �ִ�.
    // �����ϰ� ������ F5�� ������ �ȴ�.

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
        star = string.Empty; // Empy�� �� ���ڿ��� �ǹ��մϴ�. ��Ÿ�� �ʱ�ȭ�ϴ� �뵵�� ����մϴ�. �̰� ������� ������ ���� �������� ���ڿ��� �������� �� �ֽ��ϴ�.

        // ������ 1
        /*for (int i = 1; i < 6; i++) // 0���� 5���� �ݺ�
        {
            for (int j = 1; j <= i; j++)
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�
        }*/

        for (int i = 1; i < 6; i++) // 0���� 5���� �ݺ�
        {
            for (int j = 1; j <= i; j++)
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�
        }
            Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2

        /*for (int i = 1; i < 6; i++) // 0���� 5���� �ݺ�
        {
            for (int q = 5; q > i; q--) // 6���� i���� �ݺ�
            {
                star += "��"; // ����
            }
            for (int j = 0; j < i; j++)
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�
        }
        Debug.Log(star);\*/

        for (int i = 1; i < 6; i++)
        {
            for (int q = 1; q < i; q++)
            {
                star += "��"; // ����
            }
            for (int j = 6; j > i; j--)
            {
                star += "��"; // ��
            }

            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3

        for (int i = 1; i < 6; i++) // 0���� 5���� �ݺ�
        {
            for (int j = 1; j <= i; j++)
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�
            if (i >= 5)
            {
                for (int w = 5; w < 10; w++)
                {
                    for (int q = 9; q > w; q--) // 6���� i���� �ݺ�
                    {
                        star += "��"; // ��
                    }
                    star += "\n"; // �ٹٲ�
                }
            }
        }


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4
        for (int i = 1; i < 6; i++) // 0���� 5���� �ݺ�
        {
            for (int q = 5; q > i; q--) // 6���� i���� �ݺ�
            {
                star += "��"; // ����
            }
            for (int j = 0; j < i; j++)
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�

            if (i >= 5)
            {
                for (int w = 5; w < 10; w++)
                {
                    for (int e = 4; e < w; e++) // 6���� i���� �ݺ�
                    {
                        star += "��"; // ����
                    }
                    for (int r = 9; r > w; r--)
                    {
                        star += "��"; // ��
                    }
                    star += "\n"; // �ٹٲ�
                }
            }


        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        // ������ 5
        star = string.Empty;

        for (int i = 1; i < 6; i++) // 0���� 5���� �ݺ�
        {
            for (int q = 5; q > i; q--) // 6���� i���� �ݺ�
            {
                star += "��"; // ����
            }
            for (int j = 0; j < i * 2 - 1; j++)
            {
                star += "��"; // ��
            }

            star += "\n"; // �ٹٲ�

            if (i >= 5)
                for (int w = 5; w < 10; w++)
                {
                    for (int e = 4; e < w; e++) // 6���� i���� �ݺ�
                    {
                        star += "��"; // ����
                    }
                    for (int r = 9; r > w; r--)
                    {
                        star += "��"; // ��
                    }
                    star += "\n"; // �ٹٲ�
                }


        }
        Debug.Log(star);
    }
}