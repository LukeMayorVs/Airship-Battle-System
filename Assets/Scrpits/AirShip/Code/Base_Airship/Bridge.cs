using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : Base_Ship_Component
{

    [SerializeField] private Sc_Bridge m_sc_Bridge;
    [SerializeField] private int m_actionPoints;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Setups the base values of the Bridge from the scriptable object and call base setup
    protected override void Setup()
    {

        m_sc_Base_Ship_Component = m_sc_Bridge;
        m_actionPoints = m_sc_Bridge.ActionPoints;
        base.Setup();
    }
}
