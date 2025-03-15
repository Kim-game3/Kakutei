using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//float型で指定した数値の範囲の中からランダムで返す
[System.Serializable]
public class RandomGetFloat
{
    [Header("最小値")]
    [SerializeField] float _min;
    [Header("最大値")]
    [SerializeField] float _max;

    public float Min
    { 
        get { return _min; }
        set {  _min = value; } 
    }

    public float Max
    {
        get { return _max; }
        set { _max = value; }
    }

    //float型の値をランダムで得る
    public float Get()
    {
        if(_min>_max)//最小値が最大値を超えていたら警告
        {
            Debug.Log("最小値が最大値を超えています！");
        }

        return Random.Range(_min, _max);
    }
}
