using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�{�[���̂��̏�Ԃł��鎞�Ԃ��󂯎������Ԃ��ƂɕԂ�
[System.Serializable]
public class StateTime_LeanBall
{
    [Header("�]�����Ԃ̎���(s)")]
    [SerializeField] RandomGetFloat _goFlowTime;//�]�����Ԃ̎���
    [Header("�S�[���Ɍ�������Ԃ̎���(s)")]
    [SerializeField] RandomGetFloat _moveToGoalTime;//�S�[���Ɍ�������Ԃ̎���

    //��Ԃ̎��Ԃ��擾
    public float GetStateTime(EState_LeanBall state)
    {
        switch (state)
        {
            case EState_LeanBall.GoFlow: return _goFlowTime.Get(); 
            case EState_LeanBall.MoveToGoal: return _moveToGoalTime.Get();
            default: Debug.Log("��`����ĂȂ���Ԃł��I"); return 0;
        }
    }
}
