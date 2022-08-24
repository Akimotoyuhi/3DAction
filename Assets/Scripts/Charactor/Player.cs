using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
//using Cysharp.Threading.Tasks;
//using DG.Tweening;

/// <summary>
/// �v���C���[�̃N���X
/// </summary>
public class Player : CharactorBase
{
    /// <summary>�̗�</summary>
    [SerializeField] int m_life;
    /// <summary>�ړ����x</summary>
    [SerializeField] float m_moveSpeed;
    /// <summary>�W�����v��</summary>
    [SerializeField] float m_jumpPower;
    /// <summary>�U�����x</summary>
    [SerializeField] float m_attackInterval;
    /// <summary>�ڒn���������Ray�̒���</summary>
    [SerializeField] float m_isGroundRayLength;
    /// <summary>�d��</summary>
    [SerializeField] float m_gravity;
    [SerializeField] Rigidbody m_rb;

    public override void Setup()
    {
        //�W�����v
        InputEvent.Instance.JumpEvent
            .Where(b => b/* && GroundCheck()*/)
            .Subscribe(_ => Jump());

        //�ړ�
        InputEvent.Instance.MoveEvent
            .Subscribe(v => Move(v));

        //�U��
        InputEvent.Instance.Fire1Event
            .Where(b => b)
            .ThrottleFirst(System.TimeSpan.FromSeconds(m_attackInterval))
            .Subscribe(_ => Attack());

        //this.UpdateAsObservable()
        //    .Subscribe(v =>
        //    {
        //        if (Input.GetButtonDown("Jump") && GroundCheck())
        //        {
        //            Jump();
        //        }
        //        else
        //        {

        //        }
        //    });
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
        Debug.Log("�U��");
    }

    private bool GroundCheck()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(transform.position, Vector3.down * m_isGroundRayLength, Color.red);
        return Physics.Raycast(ray, m_isGroundRayLength);
    }
}
