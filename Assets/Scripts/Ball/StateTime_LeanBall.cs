using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�{�[���̂��̏�Ԃł��鎞�Ԃ��󂯎������Ԃ��ƂɕԂ�
[System.Serializable]
public class StateTime_LeanBall
{
    [Header("��Ԃ̌p������(s)")]
    [SerializeField] Mapper_State_LeanBall<RandomGetFloat> _stateTime;

    //��Ԃ̎��Ԃ��擾
    public float GetStateTime(EState_LeanBall state)
    {
        return _stateTime.Get(state).Get();
    }
}
