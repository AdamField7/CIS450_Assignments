/*
 * Adam Field
 * Assignment6EasyMode
 * Sets up evil rifle
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilRifle : Gun
{
    private void Awake()
    {
        this.GunType = "Evil Rifle";
        this.GorE = GoodOrEvil.EVIL;
        this.damage = 5;
    }
    private void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
