using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���̂ɑ΂��ă����_���ȕ����ɗ͂�������
[System.Serializable]
public class AddForceRandomDirection
{
    [Header("�͂������镨�̂̈ʒu���")]
    [SerializeField] Transform _targetTransform;
    [Header("�͂������镨�̂�RigidBody")]
    [SerializeField] Rigidbody _targetRigidBody;
    [Header("������͂̑傫���̐ݒ�")]
    [SerializeField] RandomGetFloat _power;
    [Header("�͂������镨�̂̑O(Z���{)������0���A\n���v���𐳂̕����Ƃ���")]
    [Header("�͂�����������̐ݒ�")]
    [SerializeField] RandomGetAngle _angle_AddForce;
    

    public void AddForce_Random()//�����_���ȕ����ɗ͂�������
    {
        Vector3 angle = new Vector3(0, _angle_AddForce.Get(), 0);//�͂����������(���̂��猩��y���܂���)

        Vector3 forceVec=Quaternion.Euler(angle)*_targetTransform.forward;//�͂�����������x�N�g��
        forceVec = forceVec.normalized;//�����x�N�g����P�ʃx�N�g����

        _targetRigidBody.AddForce(forceVec*_power.Get(),ForceMode.Impulse);
    }
}
