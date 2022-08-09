using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
//using Cysharp.Threading.Tasks;
//using DG.Tweening;

/// <summary>
/// �v���C���[�̃N���X
/// </summary>
public class Player : MonoBehaviour
{
    [SerializeField] int m_life;
    [SerializeField] float m_moveSpeed;
    [SerializeField] float m_jumpPower;
    [SerializeField] Rigidbody m_rb;

    private void Start()
    {
        Setup();
    }

    public void Setup()
    {
        //�W�����v
        InputEvent.Instance.JumpEvent
            .Where(b => b)
            .Subscribe(_ =>
            {
                m_rb.AddForce(Vector3.up * m_jumpPower, ForceMode.Impulse);
            });

        //�ړ�
        InputEvent.Instance.MoveEvent
            .Subscribe(v => m_rb.velocity = v * m_moveSpeed);

        //�U��
        InputEvent.Instance.Fire1Event
            .Where(b => b)
            .ThrottleFirst(System.TimeSpan.FromSeconds(1))
            .Subscribe(_ => Debug.Log("�U��"));
    }
}
