/*
 * Adam Field
 * Assignment 1
 * pistol concrete class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Item, Gun, Equipable
{
    public override float weight => 10f;

    public override void GetWeight()
    {
        Debug.Log("Weight of the pistol: " + weight);
    }

    public void Shoot()
    {
        Debug.Log("Shoot pistol bullet!");
    }

    public void Unequip()
    {
        Debug.Log("Unequip pistol");
    }
    public void Equip()
    {
        Debug.Log("Equip pistol");
    }
}
