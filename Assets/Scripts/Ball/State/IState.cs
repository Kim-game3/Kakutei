using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�X�e�[�g�̃C���^�[�t�F�[�X
public interface IState
{
    void OnEnter();  // ��ԊJ�n���ɌĂ΂��
    void OnUpdate(); // ���t���[���Ă΂��
    void OnExit();   // ��ԏI�����ɌĂ΂��
}