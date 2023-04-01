using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenuAttribute(fileName = "Bridge", menuName = "ScriptableObjects/Bridge")]
public class Sc_Bridge : Sc_Base_Ship_Component
{
    [SerializeField] private int m_actionPoints;



    //==========properties============

    public int ActionPoints
    {
        get { return m_actionPoints; }
    }

}
