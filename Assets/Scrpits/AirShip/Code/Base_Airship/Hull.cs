using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hull : Base_Ship_Component
{
    [SerializeField] private Sc_Hull m_sc_Hull;
    // Start is called before the first frame update
    [SerializeField] private int m_manoeuvring;
    [SerializeField] private int m_speed;

    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Setups the base values of the Hull from the scriptable object and call base setup
    protected override void Setup()
    {
        m_sc_Base_Ship_Component = m_sc_Hull;
        m_speed = m_sc_Hull.Speed;
        m_manoeuvring = m_sc_Hull.Manoeuvring;
        base.Setup();


    }
}
