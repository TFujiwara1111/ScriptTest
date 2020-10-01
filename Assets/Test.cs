using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
  //Use this for initialization
    void Start()
    {
        //要素数５の配列を初期化する
        int[] array = new int[5];


        //配列の各要素に値を代入する
        array [0] = 10;
        array [1] = 70;
        array [2] = 50;
        array [3] = 40;
        array [4] = 90;


        //配列の要素全てを順番に表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array [i]);
        }
        //配列の要素全てを逆順に表示する
        for (int n = 4; n > -1; n--) 
        {
            Debug.Log(array [n]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
