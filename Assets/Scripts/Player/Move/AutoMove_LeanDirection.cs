using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�|��Ă�����Ɏ����I�ɓ���
public class AutoMove_LeanDirection : MonoBehaviour
{
    [Header("�������I�u�W�F�N�g")]
    [SerializeField] Transform _target;
    [Header("�X�s�[�h")]
    [SerializeField] float _speed;
    [Header("�{�[���Ƃ̋����𑪂�R���|�[�l���g")]
    [SerializeField] CalcDistanceFromLeanBall _distanceFromLeanBall;

    void Update()
    {
        Move();
    }

    private void Move()//����
    {
        _target.Translate(CalcMoveVec(), Space.World);
    }

    private Vector3 CalcMoveVec()//�ړ��x�N�g���̎Z�o
    {
        Vector3 moveVec = _distanceFromLeanBall.Direction_ToLeanBall(_target) * _speed * Time.deltaTime;

        return moveVec;
    }
}
