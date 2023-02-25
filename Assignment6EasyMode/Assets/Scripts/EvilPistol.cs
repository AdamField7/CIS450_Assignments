/*
 * Adam Field
 * Assignment6EasyMode
 * Sets up evil pistol
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilPistol : Gun
{
    private void Awake()
    {
        this.GunType = "Evil Pistol";
        this.GorE = GoodOrEvil.EVIL;
        this.damage = 1;
    }
    private void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
