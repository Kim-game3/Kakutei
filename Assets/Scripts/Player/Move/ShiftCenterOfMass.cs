using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���͂��������ɏd�S���ړ�����悤�ɂ���
public class ShiftCenterOfMass : MonoBehaviour
{
    [Header("�d�S�����炷����")]
    [SerializeField] Rigidbody _shiftObj;
    [Header("�d�S���L�����̒��S����ő�ǂꂾ��������邩")]
    [SerializeField] float _maxDistance;
    [Header("�d�S�̈ړ��X�s�[�h")]
    [SerializeField] float _speed;

    private void Update()
    {
        ShiftCenter();
    }

    void ShiftCenter()
    {
        //���͏����擾
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        //���݂̏d�S���擾
        Vector3 currentCenter = _shiftObj.centerOfMass;

        //���͂������d�S�����炷
        Vector3 newCenter = currentCenter + _speed * Time.deltaTime * input;//�V�����d�S

        //�d�S(x,z����)��͈͓��Ɏ��߂�
        newCenter.x = Mathf.Clamp(newCenter.x, -_maxDistance, _maxDistance);
        newCenter.z = Mathf.Clamp(newCenter.z, -_maxDistance, _maxDistance);

        //�d�S���X�V
        _shiftObj.centerOfMass = newCenter;
    }


}
