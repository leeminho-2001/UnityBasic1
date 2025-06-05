using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Test : MonoBehaviour // MonoBehaviour은 유니티에서 동작하기 위해 붙어있는 친구이다.
{
    // Start is called before the first frame update


    void Awake()
    {
        Debug.Log("Awake 함수입니다. 최초 한번만 실행됩니다.");
    }


    //private void OnEnable()
    //{
    //  Debug.Log("OneEnable 함수입니다. 활성화 될 때 실행됩니다.");
    //}

    //void Start()
    //{
    //   Debug.Log("Start 함수입니다.한번 만 실행됩니다.");
    //}

    //int platerLevel = 10;
  //  new string name;
   // private void Start()
    //{
      //  name += "나의 이름은";
        //name += "김철수";
        //name += "입니다.";

        //Debug.Log(name);

//        Debug.Log("나의 레벨은" + platerLevel + "입니다.");
  //      Debug.Log($"나의 레벨은 {platerLevel}입니다.");
    //}


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update 함수입니다. 매 프레임마다 실행됩니다.");
    }

    //int Sum (int value1, int value2)// int를 이용한 더하기 함수
    //return Sum(value1 + value2);// Sum 함수는 두 개의 정수를 받아서 그 합을 반환한다.


    //변수
    //1byt = 8bit
    //4byt = 32bit
    // 즉, 4바이트는 01로 이루워진 2진수가 32개가 있다는 듯으로 2의 32승이다.
    // 2의 32승(2^32)은 약 42억이다.
    // 때문에 인트의 범위는 -2,147,483,648`(-21억)에서 `2,147,483,647`(21억)까지이다.


    //void OnEnable()
    //{
        // Random.InitState(1);-- 시드 값을 설저하는 것으로 동일 숫자로 고정된다.
        //Debug.Log(Random.Range(1, 100));
        // 1 이상 100 미만의 랜덤한 값을 만들겠다.
    //}
}
//우리가 알아야하는 코드는 유니티 C# 스크립트 기초 -1 교제에 있다.

//-우리는 Player의 Level에 비례하여 Monster의 Level을 설정해줘야 합니다.
//- Monster가 playerLevel을 수정하지 못하면서, 정보만 전달받는 방법은 무엇이 있을까요?
//- 다양한 방법이 있지만, 오늘 배운 함수, 변수, 접근 지정자만으로 생각해봅시다.
