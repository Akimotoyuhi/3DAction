using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;
//using Cysharp.Threading.Tasks;
//using DG.Tweening;

/// <summary>
/// 入力イベントを通知する
/// </summary>
public class InputEvent : MonoBehaviour
{
    private ReactiveProperty<bool> m_jump = new ReactiveProperty<bool>();
    private ReactiveProperty<bool> m_fire1 = new ReactiveProperty<bool>();
    private ReactiveProperty<bool> m_fire2 = new ReactiveProperty<bool>();
    private ReactiveProperty<Vector3> m_move = new ReactiveProperty<Vector3>();
    public IObservable<bool> JumpEvent => m_jump;
    public IObservable<bool> Fire1Event => m_fire1;
    public IObservable<bool> Fire2Event => m_fire2;
    public IObservable<Vector3> MoveEvent => m_move;
    public static InputEvent Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        m_jump.AddTo(this);
        m_fire1.AddTo(this);
        m_fire2.AddTo(this);
        m_move.AddTo(this);
    }

    private void Update()
    {
        m_jump.Value = Input.GetButtonDown("Jump");
        m_fire1.Value = Input.GetButtonDown("Fire1");
        m_fire2.Value = Input.GetButtonDown("Fire2");
        m_move.SetValueAndForceNotify(new Vector3(
                Input.GetAxis("Horizontal"),
                0,
                Input.GetAxis("Vertical")));
    }
}
