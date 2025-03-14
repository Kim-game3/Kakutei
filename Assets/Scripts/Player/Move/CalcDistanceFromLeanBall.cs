using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//測る対象(target)からLeanBall(傾きを測るためのボール)までのベクトルを測る
public class CalcDistanceFromLeanBall : MonoBehaviour
{
    [Header("LeanBall")]
    [SerializeField] Transform _leanBall;

    //測る対象(target)からLeanBall(傾きを測るためのボール)までのベクトルを返す
    public Vector3 Vec_ToLeanBall(Transform target)
    {
        return _leanBall.position - target.position; 
    }

    public Vector3 Vec_ToLeanBall(Vector3 targetPos)
    {
        return _leanBall.position - targetPos;
    }

    //測る対象(target)からLeanBall(傾きを測るためのボール)までの方向(単位ベクトル)を返す
    //upwardsは床の法線ベクトルを入れる(例えば床がworld基準で普通に下にあったらVector3.upを、Z軸ー方向にあったらVector3.forwardを入れる)
    //upwardsがVector3.up(つまり普通に下の方に床がある)の場合は第二引数は入れなくてよい

    public Vector3 Direction_ToLeanBall(Transform target)
    {
        Vector3 directionVec = Vector3.ProjectOnPlane(Vec_ToLeanBall(target), Vector3.up);
        return directionVec.normalized;
    }

    public Vector3 Direction_ToLeanBall(Vector3 targetPos)
    {
        Vector3 directionVec = Vector3.ProjectOnPlane(Vec_ToLeanBall(targetPos), Vector3.up);
        return directionVec.normalized;
    }

    public Vector3 Direction_ToLeanBall(Transform target,Vector3 upwards)
    {
        Vector3 directionVec = Vector3.ProjectOnPlane(Vec_ToLeanBall(target), upwards);
        return directionVec.normalized;
    }

    public Vector3 Direction_ToLeanBall(Vector3 targetPos, Vector3 upwards)
    {
        Vector3 directionVec = Vector3.ProjectOnPlane(Vec_ToLeanBall(targetPos), upwards);
        return directionVec.normalized;
    }

}
