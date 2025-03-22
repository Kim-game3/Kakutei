using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//�{�[�����g��C���ē]����ۂ̏��
[System.Serializable]
public class GoFlowState_LeanBall : IState
{
    [Header("�{�[���������_���ȕ����ɔ�΂��@�\�̐ݒ�")]
    [SerializeField] AddForceRandomDirection _addForceRandomDirection;
    [Header("�K�v�ȃR���|�[�l���g")]
    [SerializeField] NavMeshAgent _ballAgent;
    [SerializeField] Rigidbody _ballRigid;

    public void OnEnter()
    {
        _ballAgent.enabled = false;
        _ballRigid.isKinematic = false;

        _addForceRandomDirection.AddForce_Random();//�{�[���������_���ȕ����ɔ�΂�

        Debug.Log("������]�����");
    }

    public void OnUpdate()
    {

    }

    public void OnExit()
    {

    }
}
