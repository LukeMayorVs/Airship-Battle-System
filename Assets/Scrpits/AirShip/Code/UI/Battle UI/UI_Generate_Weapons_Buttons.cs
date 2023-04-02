using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI_Generate_Weapons_Buttons : MonoBehaviour
{

    public Button m_prefabButton;
    public List<Button> m_weaponButton =  new List<Button>();
    public GameObject m_weaponesPanel;

    private void Start()
    {
        UIGenerateAirshipWeapons.onUIGenerateAirshipGenerateWeapons += GenerateWeaponButtons;
    }
    // Start is called before the first frame update
    public void GenerateWeaponButtons(List<Weapon_Base> weapons)
    {
        foreach(Weapon_Base weapon in weapons)
        {
            Button newbutton = Instantiate(m_prefabButton);
            newbutton.gameObject.transform.SetParent(m_weaponesPanel.gameObject.transform);
            m_weaponButton.Add(newbutton);
        }
    }


    void OnClick()
    {
        m_weaponesPanel.SetActive(true);
    }
}
