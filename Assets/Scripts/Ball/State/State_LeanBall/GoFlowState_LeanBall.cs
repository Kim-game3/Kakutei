using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//ボールが身を任せて転がる際の状態
[System.Serializable]
public class GoFlowState_LeanBall : IState
{
    [Header("ボールをランダムな方向に飛ばす機能の設定")]
    [SerializeField] AddForceRandomDirection _addForceRandomDirection;
    [Header("必要なコンポーネント")]
    [SerializeField] NavMeshAgent _ballAgent;
    [SerializeField] Rigidbody _ballRigid;

    public void OnEnter()
    {
        _ballAgent.enabled = false;
        _ballRigid.isKinematic = false;

        _addForceRandomDirection.AddForce_Random();//ボールをランダムな方向に飛ばす

        Debug.Log("今から転がるよ");
    }

    public void OnUpdate()
    {

    }

    public void OnExit()
    {

    }
}
