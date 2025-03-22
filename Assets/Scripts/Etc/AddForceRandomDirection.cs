using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//物体に対してランダムな方向に力を加える
[System.Serializable]
public class AddForceRandomDirection
{
    [Header("力を加える物体の位置情報")]
    [SerializeField] Transform _targetTransform;
    [Header("力を加える物体のRigidBody")]
    [SerializeField] Rigidbody _targetRigidBody;
    [Header("加える力の大きさの設定")]
    [SerializeField] RandomGetFloat _power;
    [Header("力を加える物体の前(Z軸＋)方向を0°、\n時計回りを正の方向とする")]
    [Header("力を加える方向の設定")]
    [SerializeField] RandomGetAngle _angle_AddForce;
    

    public void AddForce_Random()//ランダムな方向に力を加える
    {
        Vector3 angle = new Vector3(0, _angle_AddForce.Get(), 0);//力を加える方向(物体から見てy軸まわりに)

        Vector3 forceVec=Quaternion.Euler(angle)*_targetTransform.forward;//力を加える方向ベクトル
        forceVec = forceVec.normalized;//方向ベクトルを単位ベクトル化

        _targetRigidBody.AddForce(forceVec*_power.Get(),ForceMode.Impulse);
    }
}
