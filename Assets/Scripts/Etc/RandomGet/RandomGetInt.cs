using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//int�^�Ŏw�肵�����l�͈̔͂̒����烉���_���ŕԂ�
[System.Serializable]
public class RandomGetInt
{
    [Header("�ŏ��l")]
    [SerializeField] int _min;
    [Header("�ő�l")]
    [SerializeField] int _max;

    public int Min
    {
        get { return _min; }
        set { _min = value; }
    }

    public int Max
    {
        get { return _max; }
        set { _max = value; }
    }

    //float�^�̒l�������_���œ���
    public int Get()
    {
        if (_min > _max)//�ŏ��l���ő�l�𒴂��Ă�����x��
        {
            Debug.Log("�ŏ��l���ő�l�𒴂��Ă��܂��I");
        }

        //int(����)�^�̏ꍇ�͍ő�l��1�������Ȃ���΁A�ő�l���܂܂�ĕԂ���Ȃ�
        return Random.Range(_min, _max+1);
    }

    public RandomGetInt(int min,int max)//�R���X�g���N�^
    {
        _min = min;
        _max = max;
    }

    public RandomGetInt() { }//�f�t�H���g�R���X�g���N�^
}