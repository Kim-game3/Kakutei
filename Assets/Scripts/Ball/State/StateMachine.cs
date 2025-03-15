using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ステートを管理する
public class StateMachine
{
    private IState _currentState;//現在の状態

    //デフォルトコンストラクタ
    public StateMachine() { }

    //コンストラクタ(InitStateには初期の状態を入れる)
    public StateMachine(IState InitState)
    {
        ChangeState(InitState);
    }

    //状態変化
    public void ChangeState(IState nextState)
    {
        if(_currentState!=null)
        {
            _currentState.OnExit();
        }

        _currentState = nextState;

        if(_currentState!=null)
        {
            _currentState.OnEnter();
        }
    }

    //毎フレーム呼び出す
    public void Update()
    {
        if(_currentState!=null)
        {
            _currentState.OnUpdate();
        }
    }

}
