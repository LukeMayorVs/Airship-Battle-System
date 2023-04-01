using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The default properties that all ship components have
//all ship components should inherite from this class 
public class Sc_Base_Ship_Component : ScriptableObject
{
    [SerializeField] string m_name;
    [SerializeField] int m_health;
    [SerializeField] int m_armor;
    [SerializeField] int m_hitChance;
    [SerializeField] bool m_destroyed = false;
    [SerializeField] bool m_targetable = true;

    //==========properties============
    public string Name
    {
        get { return m_name; }
    }
    public int Health
    {
        get { return m_health; }
    }
    public int Armor
    {
        get { return m_armor; }
    }
    public int HitChance
    {
        get { return m_hitChance; }
    }

    public bool Destroyed
    {
        get { return m_destroyed; }
    }

    public bool Targetable
    {
        get { return m_targetable; }
    }

}
