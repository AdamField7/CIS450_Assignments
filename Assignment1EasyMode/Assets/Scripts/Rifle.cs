using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Item, Gun, Equipable
{
    public override float weight => 40f;

    public override void GetWeight()
    {
        Debug.Log("Weight of the rifle: " + weight);
    }

    public void Shoot()
    {
        Debug.Log("Shoot rifle bullet!");
    }

    public void Unequip()
    {
        Debug.Log("Unequip rifle");
    }
    public void Equip()
    {
        Debug.Log("Equip rifle");
    }
}
