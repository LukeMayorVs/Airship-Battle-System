using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airship_Stats 
{

    [SerializeField] private string m_name;
    [SerializeField] private int m_moveDistance;
    [SerializeField] private int m_speed;
    [SerializeField] private int m_manoeurving;
    [SerializeField] private int m_armor;
    [SerializeField] private int m_health;
    [SerializeField] private int m_actionPoints;
    // Start is called before the first frame update


    //-------
    public string Name { get => m_name; }
    public int MoveDistance { get => m_moveDistance; }
    public int Speed { get => m_speed; }
    public int Manoeurving { get => m_manoeurving; }
    public int Armor { get => m_armor; }
    public int Health { get => m_health; }
    public int ActionPoints { get => m_actionPoints; }

    //Takes in a airship of a scritable objects and it compoments to calulate the airship stats
    //Createa genric stats class, that contains a map with the stat and name and it values to allow
    //for the looping of adding the common stats together instead of manually having to add each stat
    public  Airship_Stats(Sc_Airship sc_airship)
    {
        m_name = sc_airship.name ;
        m_moveDistance = sc_airship.MoveDistance ;
        m_speed = sc_airship.Speed;
        m_manoeurving = sc_airship.Manoeuvring;
        m_armor = sc_airship.Armor;
        m_health = sc_airship.Health;
        m_actionPoints = sc_airship.ActionPoints;

    }



}
