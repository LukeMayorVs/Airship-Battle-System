using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather_Changer_DoDamage : IDoDamage
{
    public void DoDamage(int damage)
    {
        Debug.Log("Weather Changer");
    }
}
