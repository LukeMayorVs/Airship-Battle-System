using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torpedo_DoDamage : IDoDamage
{
    public void DoDamage(int damage)
    {
        Debug.Log("Torpedo");
    }
}
