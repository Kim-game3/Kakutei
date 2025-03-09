using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���͂��������ɓ|���悤�ɗ͂�������
public class FallDown : MonoBehaviour
{
    [Header("�͂�������(�|���)����")]
    [SerializeField] Rigidbody _fallDownObj;//�͂�������(�|���)����
    [Header("�������")]
    [SerializeField] float _power;//�������
    [Header("�͂�������ʒu")]
    [SerializeField] Transform _addPowerPos;//�͂�������ʒu

    Vector3 _currentVec= new Vector3(0,0,0);//���ݗ͂������Ă������

    private void Update()
    {
        UpdatePowerVec();
    }

    private void FixedUpdate()
    {
        AddPower();
    }

    //���͏�񂩂�͂������Ă��������ύX����
    void UpdatePowerVec()
    {
        _currentVec = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
    }

    //�͂�������
    void AddPower()
    {
        Vector3 powerDirection_World=_addPowerPos.TransformDirection(_currentVec);//������͂̕���(���[���h)

        Vector3 powerVec = powerDirection_World * _power;//������͂̃x�N�g��

        _fallDownObj.AddForceAtPosition(powerVec, _addPowerPos.position);
        
    }
}
