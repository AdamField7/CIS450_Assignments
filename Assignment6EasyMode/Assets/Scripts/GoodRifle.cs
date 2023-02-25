/*
 * Adam Field
 * Assignment6EasyMode
 * Sets up good rifle
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodRifle : Gun
{
    private void Awake()
    {
        this.GunType = "Good Rifle";
        this.GorE = GoodOrEvil.GOOD;
        this.damage = 5;
    }
    private void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
