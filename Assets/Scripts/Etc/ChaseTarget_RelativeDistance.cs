using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�^�[�Q�b�g�𑊑΋������l�����Ēǂ�������
//(�ŏ��ɗ����Ă��������ێ����Ȃ���ǂ�������)
public class ChaseTarget_RelativeDistance : MonoBehaviour
{
    [Header("�ǂ�������Ώ�")]
    [SerializeField] Transform _target;//�ǂ�������Ώ�
    [Header("�ǐՎ�")]
    [SerializeField] Transform _tracker;//�ǐՎ�

    Vector3 _relativeDistance;//�ǂ�������ۂɍl�����鑊�΋���(�Q�[���J�n���ɎZ�o)

    void Start()
    {
        CalcRelativeDistance();
    }

    void Update()
    {
        UpdateTrackerPos();
    }

    void CalcRelativeDistance()//���΋������v�Z
    {
        _relativeDistance=_tracker.position - _target.position;
    }

    //�ǐՎ҂̈ʒu���X�V
    void UpdateTrackerPos()
    {
        //�Ώۂ̈ʒu�ɑ��΋��������Z�����ʒu���ǐՎ҂̈ʒu�ɂȂ�
        _tracker.position = _target.position + _relativeDistance;
    }
}
