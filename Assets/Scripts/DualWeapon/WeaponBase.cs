using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;
using DG.Tweening;

/// <summary>
/// ����̊��N���X
/// </summary>
public abstract class WeaponBase : MonoBehaviour
{
    [SerializeField] int m_baseDamage;
    [SerializeField] float m_baseSpeed;
    [SerializeField] float m_useDurasion;
    /// <summary>�g�p�Ԋu</summary>
    public float UseDurasion => m_useDurasion;

    public virtual void Setup()
    {

    }

    public virtual void Attack()
    {

    }
}
