using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボールの状態を時間ごとに切り替える
public class SwitchState_LeanBall : MonoBehaviour
{
    [Header("初期状態")]
    [SerializeField] EState_LeanBall _firstState;
    [Header("状態ごとの時間")]
    [SerializeField] StateTime_LeanBall _stateTime;
    [Header("ボールのステートマシンを動かす機能")]
    [SerializeField] RunStateMachine_LeanBall _runStateMachine;

    EState_LeanBall _currentState;//現在の状態
    Coroutine _coroutine;

    public EState_LeanBall CurrentState
    {
        get { return _currentState; }
    }

    private void Awake()
    {
        _currentState = _firstState;
    }

    private void OnEnable()
    {
        _coroutine=StartCoroutine(StateCoroutine());//コルーチンの発動
    }

    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }

    IEnumerator StateCoroutine()
    {
        while(true)
        {
            float waitTime = _stateTime.GetStateTime(_currentState);//現在の状態から何秒待つか決める
            yield return new WaitForSeconds(waitTime);//待つ

            ChangeState();//状態変化
        }
    }

    void ChangeState()//状態変化
    {
        //状態を一つ進める
        int stateNum = (int)_currentState;
        stateNum++;
        stateNum %= Enum.GetValues(typeof(EState_LeanBall)).Length;
        _currentState = (EState_LeanBall)stateNum;

        Debug.Log(_currentState+"に変化しました");

        //ステートマシンの状態を変更
        _runStateMachine.ChangeState(_currentState);
    }
}
