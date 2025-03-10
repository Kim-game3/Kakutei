using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�v���C���[�̊p�x�𓮂����ē|���悤�ɂ���
public class ShiftRotation : MonoBehaviour
{
    [Header("��]������I�u�W�F�N�g")]
    [SerializeField] Transform _rotateObj;
    [Header("�����x(1�b�Ԃɑ����鑬�x)")]
    [SerializeField] float _acceleration;
    [Header("�ő呬�x(1�b�Ԃɓ����p�x)")]
    [SerializeField] float _maxSpeed;

    Vector3 _speed=new Vector3(0,0,0);//���x

    private void Update()
    {
        ShiftRotate();
    }

    void ShiftRotate()
    {
        //���͏��̎擾
        Vector3 input = new Vector3(Input.GetAxis("Vertical"), 0f, -Input.GetAxis("Horizontal"));

        //���݂̑��x���X�V
        _speed = _speed + Time.deltaTime * _acceleration * input;

        //���x���ő呬�x�𒴂��Ȃ��悤�ɂ���
        _speed.x = Mathf.Clamp(_speed.x, -_maxSpeed, _maxSpeed);
        _speed.y = Mathf.Clamp(_speed.y, -_maxSpeed, _maxSpeed);
        _speed.z = Mathf.Clamp(_speed.z, -_maxSpeed, _maxSpeed);

        //���x�ɍ��킹�ĉ�]������
        _rotateObj.Rotate(Time.deltaTime * _speed);

    }
}
