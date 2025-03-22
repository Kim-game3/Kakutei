using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//ボールが身を任せて転がる際の状態
[System.Serializable]
public class GoFlowState_LeanBall : IState
{
    [SerializeField] NavMeshAgent _ballAgent;
    [SerializeField] Rigidbody _ballRigid;

    public void OnEnter()
    {
        _ballAgent.enabled = false;
        _ballRigid.isKinematic = false;

        //ボールをランダムな方向に飛ばす

        Debug.Log("今から転がるよ");
    }

    public void OnUpdate()
    {

    }

    public void OnExit()
    {

    }
}
