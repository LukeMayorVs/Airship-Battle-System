using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Ballista : Weapon_Base
{
    // Start is called before the first frame update
    void Start()
    {
        this.m_damageType = new Ballista_DoDamage();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
