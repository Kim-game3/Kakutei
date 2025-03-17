using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation.Editor;
using UnityEngine;
using UnityEngine.AI;

//ボールがゴールに移動する際の状態
[System.Serializable]
public class MoveToGoalState_LeanBall : IState
{
    [SerializeField] NavMeshAgent _ballAgent;
    [SerializeField] Rigidbody _ballRigid;
    [SerializeField] Transform _goal;

    public void OnEnter()
    {
        _ballRigid.isKinematic = true;
        _ballAgent.enabled = true;
        _ballAgent.SetDestination(_goal.position);
        
        Debug.Log("ゴールに向かうよ");
    }

    public void OnUpdate()
    {

    }

    public void OnExit()
    {
        _ballRigid.isKinematic = false;
        _ballAgent.enabled = false;
    }
}
