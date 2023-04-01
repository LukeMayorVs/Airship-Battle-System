using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenuAttribute(fileName = "Engine", menuName = "ScriptableObjects/Engine")]
public class Sc_Engine : Sc_Base_Ship_Component
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
