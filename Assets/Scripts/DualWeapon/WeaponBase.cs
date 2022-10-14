using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;
using DG.Tweening;

/// <summary>
/// 武器の基底クラス
/// </summary>
public abstract class WeaponBase : MonoBehaviour
{
    [SerializeField] int m_baseDamage;
    [SerializeField] float m_baseSpeed;
    [SerializeField] float m_useDurasion;
    /// <summary>使用間隔</summary>
    public float UseDurasion => m_useDurasion;

    public virtual void Setup()
    {

    }

    public virtual void Attack()
    {

    }
}
