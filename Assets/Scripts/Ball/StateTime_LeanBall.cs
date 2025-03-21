using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボールのその状態でいる時間を受け取った状態ごとに返す
[System.Serializable]
public class StateTime_LeanBall
{
    [Header("状態の継続時間(s)")]
    [SerializeField] Mapper_State_LeanBall<RandomGetFloat> _stateTime;

    //状態の時間を取得
    public float GetStateTime(EState_LeanBall state)
    {
        return _stateTime.Get(state).Get();
    }
}
