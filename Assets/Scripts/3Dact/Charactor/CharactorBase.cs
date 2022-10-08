using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
//using Cysharp.Threading.Tasks;
//using DG.Tweening;

/// <summary>
/// 全てのキャラクターの基底クラス
/// </summary>
public class CharactorBase : MonoBehaviour
{
    protected Subject<Unit> m_dead = new Subject<Unit>();
    /// <summary>自身が死んだ事を通知する</summary>
    public System.IObservable<Unit> Dead => m_dead;

    public virtual void Setup()
    {

    }
}
