using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�{�[���̏�Ԃ����Ԃ��Ƃɐ؂�ւ���
public class SwitchState_LeanBall : MonoBehaviour
{
    [Header("�������")]
    [SerializeField] EState_LeanBall _firstState;
    [Header("��Ԃ��Ƃ̎���")]
    [SerializeField] StateTime_LeanBall _stateTime;
    [Header("�{�[���̃X�e�[�g�}�V���𓮂����@�\")]
    [SerializeField] RunStateMachine_LeanBall _runStateMachine;

    EState_LeanBall _currentState;//���݂̏��
    Coroutine _coroutine;

    public EState_LeanBall CurrentState
    {
        get { return _currentState; }
    }

    private void Awake()
    {
        _currentState = _firstState;
    }

    private void OnEnable()
    {
        _coroutine=StartCoroutine(StateCoroutine());//�R���[�`���̔���
    }

    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }

    IEnumerator StateCoroutine()
    {
        while(true)
        {
            float waitTime = _stateTime.GetStateTime(_currentState);//���݂̏�Ԃ��牽�b�҂����߂�
            yield return new WaitForSeconds(waitTime);//�҂�

            ChangeState();//��ԕω�
        }
    }

    void ChangeState()//��ԕω�
    {
        //��Ԃ���i�߂�
        int stateNum = (int)_currentState;
        stateNum++;
        stateNum %= Enum.GetValues(typeof(EState_LeanBall)).Length;
        _currentState = (EState_LeanBall)stateNum;

        Debug.Log(_currentState+"�ɕω����܂���");

        //�X�e�[�g�}�V���̏�Ԃ�ύX
        _runStateMachine.ChangeState(_currentState);
    }
}
