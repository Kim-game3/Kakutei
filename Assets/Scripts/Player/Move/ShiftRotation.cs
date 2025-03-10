using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//プレイヤーの角度を動かして倒れるようにする
public class ShiftRotation : MonoBehaviour
{
    [Header("回転させるオブジェクト")]
    [SerializeField] Transform _rotateObj;
    [Header("加速度(1秒間に増える速度)")]
    [SerializeField] float _acceleration;
    [Header("最大速度(1秒間に動く角度)")]
    [SerializeField] float _maxSpeed;

    Vector3 _speed=new Vector3(0,0,0);//速度

    private void Update()
    {
        ShiftRotate();
    }

    void ShiftRotate()
    {
        //入力情報の取得
        Vector3 input = new Vector3(Input.GetAxis("Vertical"), 0f, -Input.GetAxis("Horizontal"));

        //現在の速度を更新
        _speed = _speed + Time.deltaTime * _acceleration * input;

        //速度が最大速度を超えないようにする
        _speed.x = Mathf.Clamp(_speed.x, -_maxSpeed, _maxSpeed);
        _speed.y = Mathf.Clamp(_speed.y, -_maxSpeed, _maxSpeed);
        _speed.z = Mathf.Clamp(_speed.z, -_maxSpeed, _maxSpeed);

        //速度に合わせて回転させる
        _rotateObj.Rotate(Time.deltaTime * _speed);

    }
}
