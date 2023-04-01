using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Cannon : Weapon_Base
{
    // Start is called before the first frame update
    void Start()
    {
        m_damageType = new Cannon_DoDamage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

    
}
