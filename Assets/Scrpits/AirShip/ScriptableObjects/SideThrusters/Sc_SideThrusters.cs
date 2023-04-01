using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenuAttribute(fileName = "SideThrusters", menuName = "ScriptableObjects/SideThrusters")]
public class Sc_SideThrusters : Sc_Base_Ship_Component
{
    [SerializeField] private int m_manoeuvring;


    //==========properties============
    public int Manoeuvring
    {
        get { return m_manoeuvring; }
    }

}
