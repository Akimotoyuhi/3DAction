using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
//using Cysharp.Threading.Tasks;
//using DG.Tweening;

/// <summary>
/// フィールドの管理クラス
/// </summary>
public class FieldManager : MonoBehaviour
{
    [SerializeField] Player m_playerPrefab;
    [SerializeField] Vector3 m_playerSpawnPosition;

    public void Setup()
    {
        PlayerSpawn();
    }

    public void PlayerSpawn()
    {
        Player p = Instantiate(m_playerPrefab);
        p.transform.position = m_playerSpawnPosition;
        p.Setup();
    }
}
