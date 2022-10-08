using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
//using Cysharp.Threading.Tasks;
//using DG.Tweening;

/// <summary>
/// プレイヤーのクラス
/// </summary>
public class Player : CharactorBase
{
    /// <summary>体力</summary>
    [SerializeField] int m_life;
    /// <summary>移動速度</summary>
    [SerializeField] float m_moveSpeed;
    /// <summary>ジャンプ力</summary>
    [SerializeField] float m_jumpPower;
    /// <summary>攻撃速度</summary>
    [SerializeField] float m_attackInterval;
    [SerializeField] SkillTest m_skillTest;
    /// <summary>接地判定をするRayの長さ</summary>
    [SerializeField] float m_isGroundRayLength;
    /// <summary>重力</summary>
    [SerializeField] float m_gravity;
    [SerializeField] Rigidbody m_rb;

    public override void Setup()
    {
        //ジャンプ
        //InputEvent.Instance.JumpEvent
        //    .Where(b => b/* && GroundCheck()*/)
        //    .Subscribe(_ => Jump());

        //移動
        InputEventProvider.Instance.MoveEvent
            .Subscribe(v => Move(v));

        //攻撃
        InputEventProvider.Instance.Fire1Event
            .Where(b => b)
            .ThrottleFirst(System.TimeSpan.FromSeconds(m_attackInterval))
            .Subscribe(_ => Attack());
    }

    private void Jump()
    {
        m_rb.AddForce(Vector3.up * m_jumpPower, ForceMode.Impulse);
    }

    private void Fall()
    {

    }

    private void Move(Vector3 velocity)
    {
        m_rb.velocity = velocity * m_moveSpeed;
    }

    private void Attack()
    {
        Debug.Log("攻撃");
        SkillTest s = Instantiate(m_skillTest, transform.position, transform.rotation);
        s.Setup();
        s.AddForce(transform.forward * 3);
    }

    private bool GroundCheck()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(transform.position, Vector3.down * m_isGroundRayLength, Color.red);
        return Physics.Raycast(ray, m_isGroundRayLength);
    }
}
