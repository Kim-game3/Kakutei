using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�{�[���̏�Ԃ����Ԃ��Ƃɐ؂�ւ���
public class SwitchState_LeanBall : MonoBehaviour
{
    [Header("�������")]
    [SerializeField] EState_LeanBall _firstState;
    [Header("�]�����Ԃ̎���(s)")]
    [SerializeField] RandomGetFloat _goFlowTime;//�]�����Ԃ̎���
    [Header("�S�[���Ɍ�������Ԃ̎���(s)")]
    [SerializeField] RandomGetFloat _moveToGoalTime;//�S�[���Ɍ�������Ԃ̎���
    [SerializeField] GoFlowState_LeanBall _goFlow;//�]������
    [SerializeField] MoveToGoalState_LeanBall _moveToGoal;//�S�[���Ɍ��������

    StateMachine _stateMachine;//�X�e�[�g�}�V��

    private void Start()
    {
        //�X�e�[�g�}�V���̏�����
    }

    private void Update()
    {
        _stateMachine.Update();
    }

    void ChangeState()
    {

    }
}
