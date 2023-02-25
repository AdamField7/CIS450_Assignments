/*
 * Adam Field
 * Assignment6EasyMode
 * Sets up basic gun class with enums to know if its good or evil
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public string GunType;
    public enum GoodOrEvil { GOOD, EVIL }
    public GoodOrEvil GorE;
    public int damage;

    public void Shoot()
    {
        Debug.Log("The " + this.GunType +
                    " shoots with " + this.damage + " damage.");
    }

    public override string ToString()
    {
        return "GunType: " + this.GunType + "\n" +
                      "Damage: " + this.damage;
    }
}
