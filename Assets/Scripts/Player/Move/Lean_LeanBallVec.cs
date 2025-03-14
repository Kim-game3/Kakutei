using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class Lean_LeanBallVec : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] CalcDistanceFromLeanBall _leanBall;
    [Header("どれくらいの距離を離れたら傾きが最大になるようにするか")]
    [SerializeField] float _distanceMaxAngle;
    [Header("傾きの最大角度")]
    [SerializeField] float _maxAngle;

    private void Update()
    {
        UpdateLean();
    }

    void UpdateLean()
    {
        float distance = _leanBall.Vec_ToLeanBall(_target).magnitude;//ターゲットとボールの距離
        Vector3 direction = _leanBall.Direction_ToLeanBall(_target);//ターゲットからボールへの方向

        Vector3 axis = Vector3.Cross(direction, Vector3.up);//ターゲットの回転軸
        float angle = _maxAngle * (distance / _distanceMaxAngle);//ターゲットの回転角度

        //傾きの更新
        Quaternion rot=Quaternion.AngleAxis(-angle,axis);
        _target.rotation = rot;
        
    }
}
