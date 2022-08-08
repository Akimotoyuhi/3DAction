using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
//using Cysharp.Threading.Tasks;
//using DG.Tweening;

/// <summary>
/// プレイヤーのクラス
/// </summary>
public class Player : MonoBehaviour
{
    [SerializeField] int m_life;
    [SerializeField] float m_moveSpeed;
    [SerializeField] InputEvent m_inputEvent;

    private void Start()
    {
        Setup();
    }

    public void Setup()
    {
        m_inputEvent.JumpEvent
            .Where(b => b)
            .ThrottleFirst(System.TimeSpan.FromSeconds(3))
            .Subscribe(b => Debug.Log("じゃんぷ"));
    }
}
