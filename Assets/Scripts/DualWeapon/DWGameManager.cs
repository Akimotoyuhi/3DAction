using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DWGameManager : MonoBehaviour
{
    [SerializeField] FieldManager m_fieldManager;

    void Start()
    {
        m_fieldManager.Setup();
    }

    void Update()
    {
        
    }
}
