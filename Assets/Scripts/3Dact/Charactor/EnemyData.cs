using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObject")]
public class EnemyData : ScriptableObject
{
    [SerializeField] List<EnemyDataBase> m_datas;
    public List<EnemyDataBase> Datas => m_datas;
}

[System.Serializable]
public class EnemyDataBase
{
    [SerializeField] string m_name;
    [SerializeField] int m_maxLife;
    [SerializeField] int m_power;
    [SerializeField] GameObject m_model;
}
