using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
//using Cysharp.Threading.Tasks;
//using DG.Tweening;

/// <summary>
/// ゲーム全体の管理クラス
/// </summary>
public class GameManager : MonoBehaviour
{
    [SerializeField] FieldManager m_fieldManager;
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        m_fieldManager.Setup();
    }

    private void Update()
    {
        
    }
}
