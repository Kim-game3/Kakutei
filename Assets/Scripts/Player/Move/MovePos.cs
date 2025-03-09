using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//(�v���C���[��)�ʒu�̈ړ�
public class MovePos : MonoBehaviour
{
    [Header("�v���C���[")]
    [SerializeField] Transform _player;//�v���C���[�̈ʒu
    [Header("����")]
    [SerializeField] float _speed;//����

    private void Update()
    {
        Move();
    }

    private void Move()//�ړ�
    {
        _player.Translate(CalcMoveVec(), Space.World);//�ړ�
    }

    Vector3 CalcMoveVec()//�ړ��x�N�g���̎Z�o
    {
        Vector3 moveVec = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveVec *= _speed * Time.deltaTime;

        return moveVec;
    }
}
