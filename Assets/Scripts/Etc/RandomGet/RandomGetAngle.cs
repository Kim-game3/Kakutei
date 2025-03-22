using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//指定した角度の範囲からランダムで角度を返す
//このクラスを使う際、0°の位置と正方向は使用者が決めてください(0°の位置と正方向はインスペクターにも表示するようにしてください)
//例:オブジェクトの前(Z軸＋)方向を0°、時計回り方向を正方向と定義
[System.Serializable]
public class RandomGetAngle
{
    const float _minAngle = 0;
    const float _maxAngle = 360;

    [Header("基準角度")]
    [Header("(0°の位置から正方向に)")]//0°の位置と正方向は使用者が決めてください
    [Range(_minAngle, _maxAngle)]
    [SerializeField] float _basisAngle;
    [Header("範囲")]
    [Range(_minAngle, _maxAngle)]
    [SerializeField] float _range;
    [Header("基準角度の位置からどの方向に範囲を決めるか")]
    [SerializeField] Direction_2Way _rangeDirection;
    
    public float BasisAngle
    {
        get { return _basisAngle; }
        set { _basisAngle = value; }
    }

    public float Range
    { 
        get { return _range; } 
        set {  _range = value; } 
    }

    public Direction_2Way RangeDirection
    { 
        get { return _rangeDirection; } 
        set { _rangeDirection = value; }
    }

    //角度をランダムで得る
    public float Get()
    {
        float ret = ReturnRandomAngle();

        ret = TransitToAngle_0_360(ret);//角度を0°～360°の範囲内になるよう変換

        return ret;
    }

    public RandomGetAngle(float basisAngle,float range,Direction_2Way rangeDirection)//コンストラクタ
    {
        _basisAngle = basisAngle;
        _range = range;
        _rangeDirection = rangeDirection;
    }

    public RandomGetAngle() { }//デフォルトコンストラクタ

    float ReturnRandomAngle()//指定された角度の範囲内からランダムで返す(この時返される値は負の値の時も、360を超えてることもある)
    {
        //ランダムで出す値の始点と終点の値、どちらの値が大きいかはわからないのでMathfのMinとMaxを使ってどちらが大きいかを判定する
        float start = _basisAngle;
        float end = _basisAngle + (_range * (float)_rangeDirection);

        return Random.Range(Mathf.Min(start, end), Mathf.Max(start, end));
    }

    float TransitToAngle_0_360(float angle)//渡された角度を0°～360°の値に変換する
    {
        angle %= _maxAngle;

        //返された値(角度)がマイナスになってたら、プラスの角度に変換しておく
        if (angle < _minAngle)
        {
            angle += _maxAngle;
        }

        return angle;
    }
}
