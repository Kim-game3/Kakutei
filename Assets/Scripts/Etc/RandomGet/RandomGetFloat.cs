using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//float�^�Ŏw�肵�����l�͈̔͂̒����烉���_���ŕԂ�
[System.Serializable]
public class RandomGetFloat
{
    [Header("�ŏ��l")]
    [SerializeField] float _min;
    [Header("�ő�l")]
    [SerializeField] float _max;

    public float Min
    { 
        get { return _min; }
        set {  _min = value; } 
    }

    public float Max
    {
        get { return _max; }
        set { _max = value; }
    }

    //float�^�̒l�������_���œ���
    public float Get()
    {
        if(_min>_max)//�ŏ��l���ő�l�𒴂��Ă�����x��
        {
            Debug.Log("�ŏ��l���ő�l�𒴂��Ă��܂��I");
        }

        return Random.Range(_min, _max);
    }
}
