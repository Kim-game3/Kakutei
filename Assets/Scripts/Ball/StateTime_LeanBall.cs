using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボールのその状態でいる時間を受け取った状態ごとに返す
[System.Serializable]
public class StateTime_LeanBall
{
    [Header("転がり状態の時間(s)")]
    [SerializeField] RandomGetFloat _goFlowTime;//転がり状態の時間
    [Header("ゴールに向かう状態の時間(s)")]
    [SerializeField] RandomGetFloat _moveToGoalTime;//ゴールに向かう状態の時間

    //状態の時間を取得
    public float GetStateTime(EState_LeanBall state)
    {
        switch (state)
        {
            case EState_LeanBall.GoFlow: return _goFlowTime.Get(); 
            case EState_LeanBall.MoveToGoal: return _moveToGoalTime.Get();
            default: Debug.Log("定義されてない状態です！"); return 0;
        }
    }
}
