using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//倒れてる方向に自動的に動く
public class AutoMove_LeanDirection : MonoBehaviour
{
    [Header("動かすオブジェクト")]
    [SerializeField] Transform _target;
    [Header("スピード")]
    [SerializeField] float _speed;
    [Header("ボールとの距離を測るコンポーネント")]
    [SerializeField] CalcDistanceFromLeanBall _distanceFromLeanBall;

    void Update()
    {
        Move();
    }

    private void Move()//動き
    {
        _target.Translate(CalcMoveVec(), Space.World);
    }

    private Vector3 CalcMoveVec()//移動ベクトルの算出
    {
        Vector3 moveVec = _distanceFromLeanBall.Direction_ToLeanBall(_target) * _speed * Time.deltaTime;

        return moveVec;
    }
}
