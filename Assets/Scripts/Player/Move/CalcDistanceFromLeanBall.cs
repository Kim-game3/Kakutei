using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����Ώ�(target)����LeanBall(�X���𑪂邽�߂̃{�[��)�܂ł̃x�N�g���𑪂�
public class CalcDistanceFromLeanBall : MonoBehaviour
{
    [Header("LeanBall")]
    [SerializeField] Transform _leanBall;

    //����Ώ�(target)����LeanBall(�X���𑪂邽�߂̃{�[��)�܂ł̃x�N�g����Ԃ�
    public Vector3 Vec_ToLeanBall(Transform target)
    {
        return _leanBall.position - target.position; 
    }

    public Vector3 Vec_ToLeanBall(Vector3 targetPos)
    {
        return _leanBall.position - targetPos;
    }

    //����Ώ�(target)����LeanBall(�X���𑪂邽�߂̃{�[��)�܂ł̕���(�P�ʃx�N�g��)��Ԃ�
    //upwards�͏��̖@���x�N�g��������(�Ⴆ�Ώ���world��ŕ��ʂɉ��ɂ�������Vector3.up���AZ���[�����ɂ�������Vector3.forward������)
    //upwards��Vector3.up(�܂蕁�ʂɉ��̕��ɏ�������)�̏ꍇ�͑������͓���Ȃ��Ă悢

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
