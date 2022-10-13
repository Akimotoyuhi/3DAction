using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;
using DG.Tweening;

/// <summary>
/// •Ší‚ÌŠî’êƒNƒ‰ƒX
/// </summary>
public abstract class WeaponBase : MonoBehaviour
{
    [SerializeField] int m_baseDamage;
    [SerializeField] float m_baseSpeed;

    public virtual void Setup()
    {

    }

    public virtual void Attack()
    {

    }
}
