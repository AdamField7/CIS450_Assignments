/*
 * Adam Field
 * Assignment4EasyMode
 * sets up longer range for bullet
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongerRange : GunDecorator
{
    public GunAttatchments gunAttatchments;

    public LongerRange(GunAttatchments gunAttatchments)
    {
        this.gunAttatchments = gunAttatchments;
    }

    public override float bulletSize 
    {
        get
        {
            return gunAttatchments.bulletSize;
        }
        set
        {
            gunAttatchments.bulletSize = value;
        }
    }
    public override float fireRate 
    {
        get
        {
            return gunAttatchments.fireRate;
        }
        set
        {
            gunAttatchments.fireRate = value;
        }
    }
    public override float bulletRange 
    {
        get
        {
            return gunAttatchments.bulletRange + .5f;
        }
        set
        {
            gunAttatchments.bulletRange = value;
        }
    }
}
