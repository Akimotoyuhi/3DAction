using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;
using DG.Tweening;

public class DWPlayer : MonoBehaviour
{
    private int m_hp;
    private int m_power;
    private int m_defense;
    private WeaponBase m_rightWeapon;
    private WeaponBase m_leftWeapon;
    private ReactiveProperty<bool> m_inputLeft = new ReactiveProperty<bool>();
    private ReactiveProperty<bool> m_inputRight = new ReactiveProperty<bool>();

    private void Update()
    {
        m_inputLeft.Value = Input.GetButton("Fire1");
        m_inputRight.Value = Input.GetButton("Fire2");
    }

    public void Setup(WeaponBase rightWaapon, WeaponBase leftWeapon)
    {
        m_rightWeapon = rightWaapon;
        //âEì¸óÕÇÃãììÆä«óù
        m_inputRight
            .Where(x => x)
            .ThrottleFirst(System.TimeSpan.FromSeconds(m_rightWeapon.UseDurasion))
            .Subscribe(_ => Attack(Directions.Right));

        m_leftWeapon = leftWeapon;
        //ç∂ì¸óÕÇÃãììÆä«óù
        m_inputLeft
            .Where(x => x)
            .ThrottleFirst(System.TimeSpan.FromSeconds(m_leftWeapon.UseDurasion))
            .Subscribe(_ => Attack(Directions.Left));
    }

    /// <summary>
    /// çUåÇ
    /// </summary>
    /// <param name="directions">çUåÇÇ∑ÇÈòr</param>
    public void Attack(Directions directions)
    {
        switch (directions)
        {
            case Directions.Right:
                m_rightWeapon.Attack();
                break;
            case Directions.Left:
                m_leftWeapon.Attack();
                break;
            default:
                break;
        }
    }
}

/// <summary>
/// ç∂âE
/// </summary>
public enum Directions
{
    Right,
    Left,
}
