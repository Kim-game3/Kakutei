using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//�{�[�����g��C���ē]����ۂ̏��
[System.Serializable]
public class GoFlowState_LeanBall : IState
{
    [SerializeField] NavMeshAgent _ballAgent;
    [SerializeField] Rigidbody _ballRigid;

    public void OnEnter()
    {
        _ballAgent.enabled = false;
        _ballRigid.isKinematic = false;
        Debug.Log("������]�����");
    }

    public void OnUpdate()
    {

    }

    public void OnExit()
    {

    }
}
