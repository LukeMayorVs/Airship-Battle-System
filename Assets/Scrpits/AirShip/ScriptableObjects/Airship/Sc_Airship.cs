using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenuAttribute(fileName = "Airship", menuName = "ScriptableObjects/Airship")]
public class Sc_Airship : ScriptableObject
{
    //ship stats
    [SerializeField] private string m_name;
    [SerializeField] private int m_moveDistance;
    [SerializeField] private int m_speed;
    [SerializeField] private int m_manoeurving;
    [SerializeField] private int m_armor;
    [SerializeField] private int m_health;
    [SerializeField] private int m_actionPoints;
    [SerializeField] private List<WeaponTypes> m_weaponTypes;


    //==========properties============
    public string Name
    {
        get { return m_name; }
    }
    public int MoveDistance
    {
        get { return m_moveDistance; }
    }
    public int Speed
    {
        get { return m_speed; }
    }
    public int Manoeuvring
    {
        get { return m_manoeurving; }
    }
    public int Armor
    {
        get { return m_armor; }
    }
 
    public int Health
    {
        get { return m_health; }
    }
    public int ActionPoints
    {
        get { return m_actionPoints; }
    }

    public List<WeaponTypes> WeaponTypes
    {
        get { return m_weaponTypes; }
    }

}
