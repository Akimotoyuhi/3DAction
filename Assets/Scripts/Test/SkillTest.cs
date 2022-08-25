using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;
//using DG.Tweening;

public class SkillTest : MonoBehaviour
{
    [SerializeField] Rigidbody m_rb;

    public void Setup()
    {
    }

    public void AddForce(Vector3 v) => m_rb.AddForce(v, ForceMode.Impulse);

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
