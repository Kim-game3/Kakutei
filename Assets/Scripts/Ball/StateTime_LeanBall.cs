using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ƒ{[ƒ‹‚Ì‚»‚Ìó‘Ô‚Å‚¢‚éŠÔ‚ğó‚¯æ‚Á‚½ó‘Ô‚²‚Æ‚É•Ô‚·
[System.Serializable]
public class StateTime_LeanBall
{
    [Header("ó‘Ô‚ÌŒp‘±ŠÔ(s)")]
    [SerializeField] Mapper_State_LeanBall<RandomGetFloat> _stateTime;

    //ó‘Ô‚ÌŠÔ‚ğæ“¾
    public float GetStateTime(EState_LeanBall state)
    {
        return _stateTime.Get(state).Get();
    }
}
