using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Mine_Trebuchet : Weapon_Base
{
    // Start is called before the first frame update
    void Start()
    {
        this.m_damageType = new Mine_Trebuchet_DoDamage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
