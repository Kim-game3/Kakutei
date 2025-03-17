using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボールのステートマシンを動かす
public class RunStateMachine_LeanBall : MonoBehaviour
{
    [SerializeField] GoFlowState_LeanBall _goFlow;//転がり状態
    [SerializeField] MoveToGoalState_LeanBall _moveToGoal;//ゴールに向かう状態
    StateMachine _stateMachine=new StateMachine();//ステートマシン

    //状態を変化させる
    public void ChangeState(EState_LeanBall state)
    {
        switch(state)
        {
            case EState_LeanBall.GoFlow: _stateMachine.ChangeState(_goFlow); break;
            case EState_LeanBall.MoveToGoal: _stateMachine.ChangeState(_moveToGoal); break;
            default: Debug.Log("定義されてない状態です！"); break;
        }
    }

    private void Update()
    {
        _stateMachine.Update();
    }
}
