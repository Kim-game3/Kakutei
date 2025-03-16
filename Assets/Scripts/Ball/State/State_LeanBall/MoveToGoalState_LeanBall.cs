using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボールがゴールに移動する際の状態
[System.Serializable]
public class MoveToGoalState_LeanBall : IState
{
    public void OnEnter()
    {
        Debug.Log("ゴールに向かうよ");
    }

    public void OnUpdate()
    {

    }

    public void OnExit()
    {

    }
}
