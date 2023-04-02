using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBattleScene 
{
    
   public delegate void OnBattleSceneLoad(Airship airship);
   public static OnBattleSceneLoad onBattleSceneLoad;
  
}

public class UIGenerateAirshipWeapons
{

    public delegate void OnUIGenerateAirshipWeapons(List<Weapon_Base> weapons);
    public static OnUIGenerateAirshipWeapons onUIGenerateAirshipGenerateWeapons;

}

public class UIGenerateAirshipStats
{

    public delegate void OnUIGenerateAirshipStats(Airship_Stats airshipStats);
    public static OnUIGenerateAirshipStats onUIGenerateAirshipStats;

}


