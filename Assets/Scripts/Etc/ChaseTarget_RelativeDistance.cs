using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ターゲットを相対距離を考慮して追いかける
//(最初に離してた距離を維持しながら追いかける)
public class ChaseTarget_RelativeDistance : MonoBehaviour
{
    [Header("追いかける対象")]
    [SerializeField] Transform _target;//追いかける対象
    [Header("追跡者")]
    [SerializeField] Transform _tracker;//追跡者

    Vector3 _relativeDistance;//追いかける際に考慮する相対距離(ゲーム開始時に算出)

    void Start()
    {
        CalcRelativeDistance();
    }

    void Update()
    {
        UpdateTrackerPos();
    }

    void CalcRelativeDistance()//相対距離を計算
    {
        _relativeDistance=_tracker.position - _target.position;
    }

    //追跡者の位置を更新
    void UpdateTrackerPos()
    {
        //対象の位置に相対距離を加算した位置が追跡者の位置になる
        _tracker.position = _target.position + _relativeDistance;
    }
}
