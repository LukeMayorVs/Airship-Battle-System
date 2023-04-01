using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBattleScene 
{
    
   public delegate void OnBattleSceneLoad(Airship airship);
   public static OnBattleSceneLoad onBattleSceneLoad;
  
}

public class GenerateWeapons 
{

    public delegate void OnGenerateWeapons(List<Weapon_Base> weapons);
    public static OnGenerateWeapons onGenerateWeapons;

}
