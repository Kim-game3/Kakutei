using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�X�e�[�g���Ǘ�����
public class StateMachine
{
    private IState _currentState;//���݂̏��

    //�f�t�H���g�R���X�g���N�^
    public StateMachine() { }

    //�R���X�g���N�^(InitState�ɂ͏����̏�Ԃ�����)
    public StateMachine(IState InitState)
    {
        ChangeState(InitState);
    }

    //��ԕω�
    public void ChangeState(IState nextState)
    {
        if(_currentState!=null)
        {
            _currentState.OnExit();
        }

        _currentState = nextState;

        if(_currentState!=null)
        {
            _currentState.OnEnter();
        }
    }

    //���t���[���Ăяo��
    public void Update()
    {
        if(_currentState!=null)
        {
            _currentState.OnUpdate();
        }
    }

}
