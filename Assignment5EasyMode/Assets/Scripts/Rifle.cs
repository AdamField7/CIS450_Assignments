/*
 * Adam Field
 * Assignment5EasyMode
 * creation of the rifle gun
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Gun
{
    private void Start()
    {
        this.damage = 5;
        this.gun = "Rifle";
        this.ammo = "5.56";
    }
}
