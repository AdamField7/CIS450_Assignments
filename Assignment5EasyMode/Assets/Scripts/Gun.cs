/*
 * Adam Field
 * Assignment5EasyMode
 * outline for what the concrete guns need to have
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    protected string gun { get; set; }
    protected string ammo { get; set; }
    protected int damage { get; set; }

    public override string ToString()
    {
        return "Gun: " + this.gun + "\n" +
               "Ammo: " + this.ammo + "\n" +
                "Damage: " + this.damage;
    }
}
