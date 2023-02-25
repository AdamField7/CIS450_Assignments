/*
 * Adam Field
 * Assignment6EasyMode
 * Sets up evil rocket launcher
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilRocketLauncher : Gun
{
    private void Awake()
    {
        this.GunType = "Evil Rocket Launcher";
        this.GorE = GoodOrEvil.EVIL;
        this.damage = 5;
    }
    private void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
