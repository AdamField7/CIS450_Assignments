/*
 * Adam Field
 * Assignment6EasyMode
 * Sets up good rocket launcher
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodRocketLauncher : Gun
{
    private void Awake()
    {
        this.GunType = "Good Rocket Launcher";
        this.GorE = GoodOrEvil.GOOD;
        this.damage = 5;
    }
    private void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
