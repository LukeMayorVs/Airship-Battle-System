using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Battle_System : MonoBehaviour
{
    // Start is called before the first frame update
    public UI_Generate_Weapons_Buttons generate_Weapons_Buttons;
    
    void Start()
    {
        LoadBattleScene.onBattleSceneLoad += DisplayBattleShip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This function takes in the player airship and updates the UI to use them stats
    void DisplayBattleShip(Airship airship)
    {
        generate_Weapons_Buttons.GenerateWeaponButtons(airship.WeaponTypesList);
    }


}
