using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボールの状態を時間ごとに切り替える
public class SwitchState_LeanBall : MonoBehaviour
{
    [Header("初期状態")]
    [SerializeField] EState_LeanBall _firstState;
    [Header("転がり状態の時間(s)")]
    [SerializeField] RandomGetFloat _goFlowTime;//転がり状態の時間
    [Header("ゴールに向かう状態の時間(s)")]
    [SerializeField] RandomGetFloat _moveToGoalTime;//ゴールに向かう状態の時間
    [SerializeField] GoFlowState_LeanBall _goFlow;//転がり状態
    [SerializeField] MoveToGoalState_LeanBall _moveToGoal;//ゴールに向かう状態

    StateMachine _stateMachine;//ステートマシン

    private void Start()
    {
        //ステートマシンの初期化
    }

    private void Update()
    {
        _stateMachine.Update();
    }

    void ChangeState()
    {

    }
}
