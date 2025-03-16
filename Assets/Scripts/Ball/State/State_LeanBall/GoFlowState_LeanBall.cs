using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボールが身を任せて転がる際の状態
[System.Serializable]
public class GoFlowState_LeanBall : IState
{
    public void OnEnter()
    {
        Debug.Log("今から転がるよ");
    }

    public void OnUpdate()
    {

    }

    public void OnExit()
    {

    }
}
