using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Battle_Action 
{
    [SerializeField] protected string m_name;
    [SerializeField] protected string m_description;
    [SerializeField] protected int m_actionPointCost;

    public Battle_Action(string name, int actionPointCost)
    {
        m_name = name;
        m_actionPointCost = actionPointCost;
    }
}

public class Battle_Action_Move : Battle_Action
{
    [SerializeField] private int m_speed;
    public Battle_Action_Move(string name, int actionPointCost,int speed) : base( name, actionPointCost)
    {
        m_speed = speed;
    }
}

public class Battle_Action_Attack : Battle_Action
{
    [SerializeField] private int m_damage;
    public Battle_Action_Attack(string name, int actionPointCost, int damage) : base(name, actionPointCost)
    {
        m_damage = damage;
    }
}

public class Battle_Action_Evade : Battle_Action
{
    [SerializeField] private int m_speed;
    public Battle_Action_Evade(string name, int actionPointCost, int evade) : base(name, actionPointCost)
    {
        m_speed = evade;
    }
}
