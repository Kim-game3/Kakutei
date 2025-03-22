using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//int型で指定した数値の範囲の中からランダムで返す
[System.Serializable]
public class RandomGetInt
{
    [Header("最小値")]
    [SerializeField] int _min;
    [Header("最大値")]
    [SerializeField] int _max;

    public int Min
    {
        get { return _min; }
        set { _min = value; }
    }

    public int Max
    {
        get { return _max; }
        set { _max = value; }
    }

    //float型の値をランダムで得る
    public int Get()
    {
        if (_min > _max)//最小値が最大値を超えていたら警告
        {
            Debug.Log("最小値が最大値を超えています！");
        }

        //int(整数)型の場合は最大値を1多くしなければ、最大値も含まれて返されない
        return Random.Range(_min, _max+1);
    }

    public RandomGetInt(int min,int max)//コンストラクタ
    {
        _min = min;
        _max = max;
    }

    public RandomGetInt() { }//デフォルトコンストラクタ
}