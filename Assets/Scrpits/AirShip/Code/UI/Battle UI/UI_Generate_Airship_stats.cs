using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Generate_Airship_stats : MonoBehaviour
{
    public GameObject m_prefabAirshipStat;
    public GameObject m_AirshipStats;

    // Start is called before the first frame update
    void Start()
    {
        UIGenerateAirshipStats.onUIGenerateAirshipStats += GenerateAirshipStats;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GenerateAirshipStats(Airship_Stats airshipStats)
    {
        GameObject newStat = Instantiate(m_prefabAirshipStat);
        newStat.gameObject.transform.SetParent(m_AirshipStats.gameObject.transform);
        Debug.Log("Trigger Airship stats Loading");
    }
}
