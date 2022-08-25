using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillData")]
public class NewBehaviourScript : ScriptableObject
{
    [SerializeField] List<SkillDataBase> m_datas;
    public List<SkillDataBase> Datas => m_datas;
}

[System.Serializable]
public class SkillDataBase
{
    [SerializeField] string m_name;
    [SerializeField] SkillID m_id;
    [SerializeField] float m_powerMultiply;
    [SerializeField] float m_cooltime;
    //[SerializeField] ParticleID m_particleID;
}

public enum SkillID
{
    Skill1,
    Skill2,
    Skill3,
}
