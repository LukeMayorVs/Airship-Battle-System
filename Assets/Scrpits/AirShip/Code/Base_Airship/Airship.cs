using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airship : MonoBehaviour
{
    //
    [SerializeField] private Sc_Airship m_sc_AirShip;
    //Compoments of the airship
    [SerializeField] private Hull m_hull;
    [SerializeField] private SideThrusters m_sideThrusters;
    [SerializeField] private Engine m_engine;
    [SerializeField] private Deck m_deck;
    [SerializeField] private Bridge m_bridge;
    [SerializeField] private List<Sc_WeaponTypes> m_Sc_weaponTypes;
    [SerializeField] private List<Weapon_Base> m_weaponTypesList = new List<Weapon_Base>();
    //ship stats
    [SerializeField] private string m_name;
    [SerializeField] private int m_moveDistance;
    [SerializeField] private int m_speed;
    [SerializeField] private int m_manoeurving;
    [SerializeField] private int m_armor;
    [SerializeField] private int m_health;
    [SerializeField] private int m_actionPoints;
    [SerializeField] private List<Battle_Action> m_battle_Actions = new List<Battle_Action>();

    public List<Weapon_Base> WeaponTypesList { get => m_weaponTypesList; set => m_weaponTypesList = value; }


    // Start is called before the first frame update
    void Start()
    {
        Setup();
        //Passed in the ship 
        LoadBattleScene.onBattleSceneLoad?.Invoke(this);
    }

    private void Setup()
    {

        ////loop through the weapones and create them
        //Create the default actions for all ships, rethink this to better store the value and cost;
;
        //create the weapon and a battle_actions
        foreach (var weapon in m_Sc_weaponTypes)
        {

            Weapon_Base createWeapon = null;
           switch(weapon.WeaponType)
           {
                case WeaponTypes.CANNON:
                    createWeapon = gameObject.AddComponent<Weapon_Cannon>();                   
                    break;
                case WeaponTypes.BURST_CANNON:
                    createWeapon = gameObject.AddComponent<Weapon_Burst_Cannon>();
                    break;
                case WeaponTypes.BALLISTA:
                    createWeapon = gameObject.AddComponent<Weapon_Ballista>();
                    break;
                case WeaponTypes.FLAMER:
                    createWeapon = gameObject.AddComponent<Weapon_Flamer>();
                    break;
                case WeaponTypes.HARPOON:
                    createWeapon = gameObject.AddComponent<Weapon_Harpoon>();
                    break;
                case WeaponTypes.MINE_TREBUCHET:
                    createWeapon = gameObject.AddComponent<Weapon_Mine_Trebuchet>();
                    break;
                case WeaponTypes.RAM:
                    createWeapon = gameObject.AddComponent<Weapon_Ram>();
                    break;
                case WeaponTypes.TORPEDO:
                    createWeapon = gameObject.AddComponent<Weapon_Torpedo>();
                    break;
                case WeaponTypes.WEATHER_CHANGER:
                    createWeapon = gameObject.AddComponent<Weapon_Weather_Changer>();
                    break;
            }

            createWeapon.Init(weapon);
            m_weaponTypesList.Add(createWeapon);

        }
        GenerateWeapons.onGenerateWeapons?.Invoke(m_weaponTypesList);
        //Calulate the baseship stats

    }

}
