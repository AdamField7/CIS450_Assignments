/*
 * Adam Field
 * Assignment4EasyMode
 * sets up faster firing for bullet
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasterFiring : GunDecorator
{
    public GunAttatchments gunAttatchments;

    public FasterFiring(GunAttatchments gunAttatchments)
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
            return gunAttatchments.fireRate - .1f;
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
            return gunAttatchments.bulletRange;
        }
        set
        {
            gunAttatchments.bulletRange = value;
        }
    }
}
