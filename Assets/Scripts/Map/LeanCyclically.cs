using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//z軸を起点に周期的に傾く
public class LeanCyclically : MonoBehaviour
{
    [Header("傾かせるオブジェクト")]
    [SerializeField] Transform _leanObj;
    [Header("最大で傾く角度")]
    [SerializeField] float _maxAngle;
    [Header("周期(秒)")]
    [SerializeField] float _cycle;
    float _elapsedTime = 0;//経過時間

    public float MaxAngle//最大で傾く角度
    {
        get { return _maxAngle; }
        set { _maxAngle = value; }
    }

    public float Cycle//周期(秒)
    {
        get { return _cycle; }
        set { _cycle = value; }
    }

    public float Phase//現在の周期の位置(位相)
    {
        get { return Mathf.Sin(2 * Mathf.PI * _elapsedTime / _cycle); }
    }

    private void Update()
    {
        UpdateLean();
    }

    void UpdateLean()
    {
        //経過時間を更新
        _elapsedTime += Time.deltaTime;
        _elapsedTime%= _cycle;//１周期分の時間を超えないようにする(増やし続けていずれオーバーフローするのが怖いから)

        //角度を更新
        Vector3 angle = _leanObj.eulerAngles;
        angle.z = Phase * _maxAngle;
        _leanObj.eulerAngles = angle;
    }
}
