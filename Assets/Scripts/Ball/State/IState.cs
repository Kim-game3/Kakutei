using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ステートのインターフェース
public interface IState
{
    void OnEnter();  // 状態開始時に呼ばれる
    void OnUpdate(); // 毎フレーム呼ばれる
    void OnExit();   // 状態終了時に呼ばれる
}