using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//��Ʈ�� + a = ��� ����
//��Ʈ�� + k + d = �� ����

public class IF_First : MonoBehaviour
{
    // for(int �ݺ��� ����ϴ� ���� (���� i) = 0(���� �� �ʱ�ȭ); �ݺ��� ����ϴ� ���� < 100(�ݺ� �ϴ� ���� / ����� 100�̸� �� �ݺ� ��, 0~99�� �ݺ�); �ݺ��� ����ϴ� ���� ++(������ / �����  1�� ����))
    // �츮�� for���� ���������� Ư�� Ƚ����ŭ �ݺ��ϴ� �Ϳ� ����ϱ� ������
    // for(int i = 0; i < 10; i++) // 0���� 9���� �ݺ��ϴ� for��
    // for(int i = 0; i <=9; i++) // 0���� 9���� �ݺ��ϴ� for��
    // for int i = 10; i > 0; i--) // 10���� 1���� �ݺ��ϴ� for��
    private void Awake()
    {
        count = 0; // �ʱ�ȭ
    }

    int count;


   // void Start()
    //{
      //  for(int i = 0; i < 5; i++)
       // {
       //     Debug.Log("�ݺ����� ����Ǿ����.");
       // }

        // i = 0 , 0 < 5
       // Debug.Log("�ݺ����� ����Ǿ����.");
        // i ++

        // i = 1 ������ 5���� �۴�.
        //Debug.Log("�ݺ����� ����Ǿ����.");
        // i ++

        // i = 2 ������ 5���� �۴�.
        //Debug.Log("�ݺ����� ����Ǿ����.");
        // i ++

        // i = 3 ������ 5���� �۴�.
        //Debug.Log("�ݺ����� ����Ǿ����.");
        // i ++

        // i = 4 ������ 5���� �۴�.
        //Debug.Log("�ݺ����� ����Ǿ����.");
        // i ++

        // i = 5 ���� 5���� ���� �ʴ�.
        // Debug.Log("�ݺ����� ����Ǿ����."); �� ������ �ʰ� �ݺ����� ����ȴ�.
    //}


    void Start()//private�� �����Ǿ��ִ� ���̴�.
    {
    }

    public void Gacha()
    {
        int randomValue = Random.Range(1, 101); // 1���� 100������ ������ �������� ��ȯ�մϴ�.
        Debug.Log($"������ ���� : {randomValue}�Դϴ�.");
        int number = 0;

        while (number < 10)
        {
            if (8 <= count)
            {
                count = 0; //�ʱ�ȭ
                Debug.Log("Ȯ��! '��û'�� �̾Ҵ�!");
            }
            else if (randomValue <= 10)//=>�ش� �Լ��� 10%�� �ǹ� // 10%Ȯ���� ��쿡�� // 1~10
            {
                Debug.Log("'��û'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30)// => �ش� �Լ��� 20% ������ 10%�� �ɷ����� ������ 20%�� �ǹ��Ѵ�. // 20%Ȯ���� ��쿡�� // 11~30
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else if (randomValue <= 60)
            {
                Debug.Log("'�� �༮'�� �̾Ҵ�!");
            }
            else // �� �̿��� ��쿡��
            {
                Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
            }
            count++; // ī��Ʈ ����
            number++;
        }



        //Ȯ���� 10%�� ��� �α׿� '��û'�� �̾Ҵ�!
        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        // �� �̿��� ��쿡�� ġġ 'ġġ'�� �̾ƹ��ȴ�!



        //for (int i = 0; i < 10; i++) // for �ϰ� ��Ű ������ �ڵ����� �ݺ����� �����ȴ�.
        //{

            //if (8 <= count)
            //{
              //  count = 0; //�ʱ�ȭ
             //   Debug.Log("Ȯ��! '��û'�� �̾Ҵ�!");
            //}
            //else if (randomValue <= 10)//=>�ش� �Լ��� 10%�� �ǹ� // 10%Ȯ���� ��쿡�� // 1~10
            //{
             //   Debug.Log("'��û'�� �̾Ҵ�!");
            //}
            //else if (randomValue <= 30)// => �ش� �Լ��� 20% ������ 10%�� �ɷ����� ������ 20%�� �ǹ��Ѵ�. // 20%Ȯ���� ��쿡�� // 11~30
            //{
            //    Debug.Log("'��'�� �̾Ҵ�!");
           // }
            //else if (randomValue <= 60)
           // {
             //   Debug.Log("'�� �༮'�� �̾Ҵ�!");
            //}
            //else // �� �̿��� ��쿡��
           // {
              //  Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
            //}
          //  count++; // ī��Ʈ ����
        //}

    }

   
    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe) //0
            // switch�� �Է��ϰ� ��  Ű�� ������ �ڵ����� �����ȴ�.
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // �Ⱦ� ĳ�� : �̹� �̱⿡ Ȯ���� ����  �����Ǵ� ĳ����
                        // �������� Ư�� ĳ���͸� ��ǥ�ϰ� �̰� ����� �ý���
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 2:
                // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            default:
                // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;
        }
    }


    void Update()
    {
    }
}
