using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//入力した方向に重心が移動するようにする
public class ShiftCenterOfMass : MonoBehaviour
{
    [Header("重心をずらす物体")]
    [SerializeField] Rigidbody _shiftObj;
    [Header("重心がキャラの中心から最大どれだけ離れられるか")]
    [SerializeField] float _maxDistance;
    [Header("重心の移動スピード")]
    [SerializeField] float _speed;

    private void Update()
    {
        ShiftCenter();
    }

    void ShiftCenter()
    {
        //入力情報を取得
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        //現在の重心を取得
        Vector3 currentCenter = _shiftObj.centerOfMass;

        //入力した分重心をずらす
        Vector3 newCenter = currentCenter + _speed * Time.deltaTime * input;//新しい重心

        //重心(x,z方向)を範囲内に収める
        newCenter.x = Mathf.Clamp(newCenter.x, -_maxDistance, _maxDistance);
        newCenter.z = Mathf.Clamp(newCenter.z, -_maxDistance, _maxDistance);

        //重心を更新
        _shiftObj.centerOfMass = newCenter;
    }


}
