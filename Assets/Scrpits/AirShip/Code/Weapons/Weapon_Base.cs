using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Base : Base_Ship_Component
{
    private int m_damage = 0;
    [SerializeField] private int m_actionPointCost;
    [SerializeField] private int m_range;
    protected IDoDamage m_damageType;
    protected Sc_WeaponTypes m_sc_WeaponType;

    //-------properties-----------//

    public Sc_WeaponTypes WeaponTypes
    {
        set { m_sc_WeaponType = value; }

    }
    public IDoDamage DamageType
    {
        set { m_damageType = value; }
    }
    public int Damage
    {
        get { return m_damage; }
    }
    public int ActionPointCost
    {
        get { return m_actionPointCost; }
    }
    public int Range
    {
        get { return m_range; }
    }

    // Start is called before the first frame update
    void  Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryDoAttack()
    {
        m_damageType.DoDamage(m_damage);
    }

    protected override void Setup()
    {
        this.m_sc_Base_Ship_Component = m_sc_WeaponType;
        this.m_range = m_sc_WeaponType.Range;
        this.m_damage = m_sc_WeaponType.Damage;
        base.Setup();
    }

    public void Init(Sc_WeaponTypes sc_WeaponType)
    {
        m_sc_WeaponType = sc_WeaponType;
        Setup();
    }


}
