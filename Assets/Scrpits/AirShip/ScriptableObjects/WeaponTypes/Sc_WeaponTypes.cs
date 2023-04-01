using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "Armament", menuName = "ScriptableObjects/Armament")]

public class Sc_WeaponTypes : Sc_Base_Ship_Component
{
    [SerializeField] private int m_damage;
    [SerializeField] private int m_actionPointCost;
    [SerializeField] private int m_range;
    [SerializeField] private WeaponTypes m_weaponType;

    //==========properties============
    public int Damage
    {
        get { return m_damage; }
    }
    public int ActionPointCost
    {
        get { return m_actionPointCost; }
    }
    public int Range
    {
        get { return m_range; }
    }
    public WeaponTypes WeaponType
    {
        get { return m_weaponType; }
    }

}

