using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�w�肵���p�x�͈̔͂��烉���_���Ŋp�x��Ԃ�
//���̃N���X���g���ہA0���̈ʒu�Ɛ������͎g�p�҂����߂Ă�������(0���̈ʒu�Ɛ������̓C���X�y�N�^�[�ɂ��\������悤�ɂ��Ă�������)
//��:�I�u�W�F�N�g�̑O(Z���{)������0���A���v�������𐳕����ƒ�`
[System.Serializable]
public class RandomGetAngle
{
    const float _minAngle = 0;
    const float _maxAngle = 360;

    [Header("��p�x")]
    [Header("(0���̈ʒu���琳������)")]//0���̈ʒu�Ɛ������͎g�p�҂����߂Ă�������
    [Range(_minAngle, _maxAngle)]
    [SerializeField] float _basisAngle;
    [Header("�͈�")]
    [Range(_minAngle, _maxAngle)]
    [SerializeField] float _range;
    [Header("��p�x�̈ʒu����ǂ̕����ɔ͈͂����߂邩")]
    [SerializeField] Direction_2Way _rangeDirection;
    
    public float BasisAngle
    {
        get { return _basisAngle; }
        set { _basisAngle = value; }
    }

    public float Range
    { 
        get { return _range; } 
        set {  _range = value; } 
    }

    public Direction_2Way RangeDirection
    { 
        get { return _rangeDirection; } 
        set { _rangeDirection = value; }
    }

    //�p�x�������_���œ���
    public float Get()
    {
        float ret = ReturnRandomAngle();

        ret = TransitToAngle_0_360(ret);//�p�x��0���`360���͈͓̔��ɂȂ�悤�ϊ�

        return ret;
    }

    public RandomGetAngle(float basisAngle,float range,Direction_2Way rangeDirection)//�R���X�g���N�^
    {
        _basisAngle = basisAngle;
        _range = range;
        _rangeDirection = rangeDirection;
    }

    public RandomGetAngle() { }//�f�t�H���g�R���X�g���N�^

    float ReturnRandomAngle()//�w�肳�ꂽ�p�x�͈͓̔����烉���_���ŕԂ�(���̎��Ԃ����l�͕��̒l�̎����A360�𒴂��Ă邱�Ƃ�����)
    {
        //�����_���ŏo���l�̎n�_�ƏI�_�̒l�A�ǂ���̒l���傫�����͂킩��Ȃ��̂�Mathf��Min��Max���g���Ăǂ��炪�傫�����𔻒肷��
        float start = _basisAngle;
        float end = _basisAngle + (_range * (float)_rangeDirection);

        return Random.Range(Mathf.Min(start, end), Mathf.Max(start, end));
    }

    float TransitToAngle_0_360(float angle)//�n���ꂽ�p�x��0���`360���̒l�ɕϊ�����
    {
        angle %= _maxAngle;

        //�Ԃ��ꂽ�l(�p�x)���}�C�i�X�ɂȂ��Ă���A�v���X�̊p�x�ɕϊ����Ă���
        if (angle < _minAngle)
        {
            angle += _maxAngle;
        }

        return angle;
    }
}
