using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//ƒ{[ƒ‹‚ªg‚ğ”C‚¹‚Ä“]‚ª‚éÛ‚Ìó‘Ô
[System.Serializable]
public class GoFlowState_LeanBall : IState
{
    [SerializeField] NavMeshAgent _ballAgent;
    [SerializeField] Rigidbody _ballRigid;

    public void OnEnter()
    {
        _ballAgent.enabled = false;
        _ballRigid.isKinematic = false;
        Debug.Log("¡‚©‚ç“]‚ª‚é‚æ");
    }

    public void OnUpdate()
    {

    }

    public void OnExit()
    {

    }
}
