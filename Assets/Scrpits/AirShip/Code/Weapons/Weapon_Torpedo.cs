using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Torpedo : Weapon_Base
{
    // Start is called before the first frame update
    void Start()
    {
        this.m_damageType = new Torpedo_DoDamage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
