/*
 * Adam Field
 * Assignment 1
 * Rocket launcher concrete class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : Item, Gun, Equipable
{
    public override float weight => 100f;

    public override void GetWeight()
    {
        Debug.Log("Weight of the rocket launcher: " + weight);
    }

    public void Shoot()
    {
        Debug.Log("Shoot Rocket!");
    }

    public void Unequip()
    {
        Debug.Log("Unequip rocket launcher");
    }
    public void Equip()
    {
        Debug.Log("Equip rocket launcher");
    }
}
