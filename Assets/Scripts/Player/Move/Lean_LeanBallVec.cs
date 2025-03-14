using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class Lean_LeanBallVec : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] CalcDistanceFromLeanBall _leanBall;
    [Header("�ǂꂭ�炢�̋����𗣂ꂽ��X�����ő�ɂȂ�悤�ɂ��邩")]
    [SerializeField] float _distanceMaxAngle;
    [Header("�X���̍ő�p�x")]
    [SerializeField] float _maxAngle;

    private void Update()
    {
        UpdateLean();
    }

    void UpdateLean()
    {
        float distance = _leanBall.Vec_ToLeanBall(_target).magnitude;//�^�[�Q�b�g�ƃ{�[���̋���
        Vector3 direction = _leanBall.Direction_ToLeanBall(_target);//�^�[�Q�b�g����{�[���ւ̕���

        Vector3 axis = Vector3.Cross(direction, Vector3.up);//�^�[�Q�b�g�̉�]��
        float angle = _maxAngle * (distance / _distanceMaxAngle);//�^�[�Q�b�g�̉�]�p�x

        //�X���̍X�V
        Quaternion rot=Quaternion.AngleAxis(-angle,axis);
        _target.rotation = rot;
        
    }
}
