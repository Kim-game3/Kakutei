using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�{�[���̃X�e�[�g�}�V���𓮂���
public class RunStateMachine_LeanBall : MonoBehaviour
{
    [SerializeField] GoFlowState_LeanBall _goFlow;//�]������
    [SerializeField] MoveToGoalState_LeanBall _moveToGoal;//�S�[���Ɍ��������
    StateMachine _stateMachine=new StateMachine();//�X�e�[�g�}�V��

    //��Ԃ�ω�������
    public void ChangeState(EState_LeanBall state)
    {
        switch(state)
        {
            case EState_LeanBall.GoFlow: _stateMachine.ChangeState(_goFlow); break;
            case EState_LeanBall.MoveToGoal: _stateMachine.ChangeState(_moveToGoal); break;
            default: Debug.Log("��`����ĂȂ���Ԃł��I"); break;
        }
    }

    private void Update()
    {
        _stateMachine.Update();
    }
}
