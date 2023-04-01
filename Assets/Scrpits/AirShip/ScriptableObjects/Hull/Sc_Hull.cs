using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "Hull", menuName = "ScriptableObjects/Hull")]
public class Sc_Hull : Sc_Base_Ship_Component
{

    [SerializeField] private int m_speed;
    [SerializeField] private int m_manoeuvring;

    //==========properties============
    public int Manoeuvring
    {
        get { return m_manoeuvring; }
    }
    public int Speed
    {
        get { return m_speed; }
    }


}
