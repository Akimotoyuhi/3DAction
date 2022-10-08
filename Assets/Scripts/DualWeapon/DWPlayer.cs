using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;
using DG.Tweening;

public class DWPlayer : MonoBehaviour
{
    [SerializeField] float m_leftCooltime;
    [SerializeField] float m_rightCooltime;
    private int m_hp;
    private int m_power;
    private int m_defense;
    private ReactiveProperty<bool> m_inputLeft = new ReactiveProperty<bool>();
    private ReactiveProperty<bool> m_inputRight = new ReactiveProperty<bool>();

    public void Start()
    {
        //¶“ü—Í‚Ì‹““®ŠÇ—
        m_inputLeft
            .Where(x => x)
            .ThrottleFirst(System.TimeSpan.FromSeconds(m_leftCooltime))
            .Subscribe(_ => Debug.Log("¶“ü—Í"));

        //‰E“ü—Í‚Ì‹““®ŠÇ—
        m_inputRight
            .Where(x => x)
            .ThrottleFirst(System.TimeSpan.FromSeconds(m_rightCooltime))
            .Subscribe(_ => Debug.Log("‰E“ü—Í"));
    }

    private void Update()
    {
        m_inputLeft.Value = Input.GetButton("Fire1");
        m_inputRight.Value = Input.GetButton("Fire2");
    }

    public void Setup()
    {

    }
}
