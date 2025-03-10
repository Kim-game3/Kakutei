using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//z�����N�_�Ɏ����I�ɌX��
public class LeanCyclically : MonoBehaviour
{
    [Header("�X������I�u�W�F�N�g")]
    [SerializeField] Transform _leanObj;
    [Header("�ő�ŌX���p�x")]
    [SerializeField] float _maxAngle;
    [Header("����(�b)")]
    [SerializeField] float _cycle;
    float _elapsedTime = 0;//�o�ߎ���

    public float MaxAngle//�ő�ŌX���p�x
    {
        get { return _maxAngle; }
        set { _maxAngle = value; }
    }

    public float Cycle//����(�b)
    {
        get { return _cycle; }
        set { _cycle = value; }
    }

    public float Phase//���݂̎����̈ʒu(�ʑ�)
    {
        get { return Mathf.Sin(2 * Mathf.PI * _elapsedTime / _cycle); }
    }

    private void Update()
    {
        UpdateLean();
    }

    void UpdateLean()
    {
        //�o�ߎ��Ԃ��X�V
        _elapsedTime += Time.deltaTime;
        _elapsedTime%= _cycle;//�P�������̎��Ԃ𒴂��Ȃ��悤�ɂ���(���₵�����Ă�����I�[�o�[�t���[����̂��|������)

        //�p�x���X�V
        Vector3 angle = _leanObj.eulerAngles;
        angle.z = Phase * _maxAngle;
        _leanObj.eulerAngles = angle;
    }
}
