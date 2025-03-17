using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//渡したボールの状態(enum型)に対応した要素を渡したり、更新する
[System.Serializable]
public class Mapper_State_LeanBall<T>
{
    [Header("転がり状態")]
    [SerializeField] T _element_GoFlow;
    [Header("ゴールに向かう状態")]
    [SerializeField] T _element_MoveToGoal;

    public T Get(EState_LeanBall state)
    {
        switch(state)
        {
            case EState_LeanBall.GoFlow: return _element_GoFlow;
            case EState_LeanBall.MoveToGoal: return _element_MoveToGoal;
            default: Debug.Log("定義されてない状態です！"); return default(T);
        }
    }

    public void Rewrite(EState_LeanBall state,T newValue)
    {
        switch (state)
        {
            case EState_LeanBall.GoFlow: _element_GoFlow = newValue; break;
            case EState_LeanBall.MoveToGoal: _element_MoveToGoal = newValue; break;
            default: Debug.Log("定義されてない状態です！"); break;
        }
    }

    
}
