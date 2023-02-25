/*
 * Adam Field
 * Assignment6EasyMode
 * sets up good pistol
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodPistol : Gun
{
    private void Awake()
    {
        this.GunType = "Good Pistol";
        this.GorE = GoodOrEvil.GOOD;
        this.damage = 1;
    }
    private void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
