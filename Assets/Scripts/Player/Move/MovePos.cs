using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//(プレイヤーの)位置の移動
public class MovePos : MonoBehaviour
{
    [Header("プレイヤー")]
    [SerializeField] Transform _player;//プレイヤーの位置
    [Header("速さ")]
    [SerializeField] float _speed;//速さ

    private void Update()
    {
        Move();
    }

    private void Move()//移動
    {
        _player.Translate(CalcMoveVec(), Space.World);//移動
    }

    Vector3 CalcMoveVec()//移動ベクトルの算出
    {
        Vector3 moveVec = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveVec *= _speed * Time.deltaTime;

        return moveVec;
    }
}
