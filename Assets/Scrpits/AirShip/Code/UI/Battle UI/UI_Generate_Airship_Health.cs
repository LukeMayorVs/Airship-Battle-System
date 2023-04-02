using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Generate_Airship_Health : MonoBehaviour
{
    public GameObject m_prefabHealth;
    public GameObject m_healthPanel;

    // Start is called before the first frame update
    void Start()
    {
        UIGenerateAirshipStats.onUIGenerateAirshipStats += GenerateAirshipHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateAirshipHealth(Airship_Stats airship_Stats)
    {
        GameObject newbutton = Instantiate(m_prefabHealth);
        newbutton.gameObject.transform.SetParent(m_healthPanel.gameObject.transform);
    }

}
