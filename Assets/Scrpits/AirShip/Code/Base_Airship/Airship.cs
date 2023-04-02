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
    [SerializeField] private Airship_Stats m_airship_Stats;

    public List<Weapon_Base> WeaponTypesList { get => m_weaponTypesList; set => m_weaponTypesList = value; }


    // Start is called before the first frame update
    void Start()
    {
        Setup();
        //Passed in the ship, FOr now use this to test for loading in the ui elements.
        //Update once have a scene/loading manager and then trigger these events in there instead
        UIGenerateAirshipWeapons.onUIGenerateAirshipGenerateWeapons.Invoke(m_weaponTypesList);
        UIGenerateAirshipStats.onUIGenerateAirshipStats.Invoke(m_airship_Stats);
        
    }

    private void Setup()
    {
        m_airship_Stats = new Airship_Stats(m_sc_AirShip);
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

    }

}
