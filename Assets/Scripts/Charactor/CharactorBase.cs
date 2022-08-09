using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
//using Cysharp.Threading.Tasks;
//using DG.Tweening;

/// <summary>
/// �S�ẴL�����N�^�[�̊��N���X
/// </summary>
public class CharactorBase : MonoBehaviour
{
    protected Subject<Unit> m_dead = new Subject<Unit>();
    public System.IObservable<Unit> Dead => m_dead;

    public virtual void Setup()
    {

    }
}
