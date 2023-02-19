/*
 * Adam Field
 * Assignment5EasyMode
 * creation of the rocket launcher gun
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : Gun
{
    private void Start()
    {
        this.damage = 10;
        this.gun = "Rocket Launcher";
        this.ammo = "Rocket";
    }
}
