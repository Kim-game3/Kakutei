using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�n�����{�[���̏��(enum�^)�ɑΉ������v�f��n������A�X�V����
[System.Serializable]
public class Mapper_State_LeanBall<T>
{
    [Header("�]������")]
    [SerializeField] T _element_GoFlow;
    [Header("�S�[���Ɍ��������")]
    [SerializeField] T _element_MoveToGoal;

    public T Get(EState_LeanBall state)
    {
        switch(state)
        {
            case EState_LeanBall.GoFlow: return _element_GoFlow;
            case EState_LeanBall.MoveToGoal: return _element_MoveToGoal;
            default: Debug.Log("��`����ĂȂ���Ԃł��I"); return default(T);
        }
    }

    public void Rewrite(EState_LeanBall state,T newValue)
    {
        switch (state)
        {
            case EState_LeanBall.GoFlow: _element_GoFlow = newValue; break;
            case EState_LeanBall.MoveToGoal: _element_MoveToGoal = newValue; break;
            default: Debug.Log("��`����ĂȂ���Ԃł��I"); break;
        }
    }

    
}
