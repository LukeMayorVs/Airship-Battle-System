using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Ship_Component : MonoBehaviour
{
    [SerializeField] protected Sc_Base_Ship_Component m_sc_Base_Ship_Component;
    [SerializeField] protected  string m_name;
    [SerializeField] protected  int m_health;
    [SerializeField] protected  int m_armor;
    [SerializeField] protected  int m_hitChance;
    [SerializeField] protected  bool m_destroyed = false;
    [SerializeField] protected  bool m_targetable = true;

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


    // Start is called before the first frame update
    public void Start()
    {
        Setup();
    }

    //This use the Sc_Base_Ship_Component scritpable object to set up the values for the Base_Ship_Component
    protected virtual void Setup()
    {
        m_name = m_sc_Base_Ship_Component.Name;
        m_health = m_sc_Base_Ship_Component.Health;
        m_armor = m_sc_Base_Ship_Component.Armor;
        m_hitChance = m_sc_Base_Ship_Component.HitChance;
        m_destroyed = m_sc_Base_Ship_Component.Destroyed;
        m_targetable = m_sc_Base_Ship_Component.Targetable;

    }
    //THis will Apply the damage a ship/Compoment Take
    protected void TakeDamage()
    {
        Debug.LogError("Not implemented TakeDamage");
    }

    //THis will return the damage a ship/Compoment Take
    protected void CalulateDamage()
    {
        Debug.LogError("Not implemented CalulateDamage");
    }
}
