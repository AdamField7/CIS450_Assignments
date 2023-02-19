/*
 * Adam Field
 * Assignment5EasyMode
 * the creation of the pistol gun
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    private void Start()
    {
        this.damage = 1;
        this.gun = "Pistol";
        this.ammo = "9mm";
    }
}
