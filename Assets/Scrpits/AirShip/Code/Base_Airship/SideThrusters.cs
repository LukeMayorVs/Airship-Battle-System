using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideThrusters : Base_Ship_Component
{
    [SerializeField] private Sc_SideThrusters sc_SideThrusters;
    [SerializeField] private int m_manoeuvring;
    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Setups the base values of the sideThrusters from the scriptable object and call base setup
     protected override void Setup()
    {
        m_sc_Base_Ship_Component = sc_SideThrusters;
        m_manoeuvring = sc_SideThrusters.Manoeuvring;
        m_name = sc_SideThrusters.name;
        base.Setup();
    }
}
