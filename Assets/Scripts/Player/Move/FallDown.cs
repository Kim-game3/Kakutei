using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//入力した方向に倒れるように力を加える
public class FallDown : MonoBehaviour
{
    [Header("力を加える(倒れる)物体")]
    [SerializeField] Rigidbody _fallDownObj;//力を加える(倒れる)物体
    [Header("加える力")]
    [SerializeField] float _power;//加える力
    [Header("力を加える位置")]
    [SerializeField] Transform _addPowerPos;//力を加える位置

    Vector3 _currentVec= new Vector3(0,0,0);//現在力を加えている方向

    private void Update()
    {
        UpdatePowerVec();
    }

    private void FixedUpdate()
    {
        AddPower();
    }

    //入力情報から力を加えている方向を変更する
    void UpdatePowerVec()
    {
        _currentVec = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
    }

    //力を加える
    void AddPower()
    {
        Vector3 powerDirection_World=_addPowerPos.TransformDirection(_currentVec);//加える力の方向(ワールド)

        Vector3 powerVec = powerDirection_World * _power;//加える力のベクトル

        _fallDownObj.AddForceAtPosition(powerVec, _addPowerPos.position);
        
    }
}
