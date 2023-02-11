/*
 * Adam Field
 * Assignment4EasyMode
 * sets up making the bullet bigger
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiggerBullets : GunDecorator
{
    public GunAttatchments gunAttatchments;

    public BiggerBullets(GunAttatchments gunAttatchments)
    {
        this.gunAttatchments = gunAttatchments;
    }

    public override float bulletSize
    {
        get
        {
            return gunAttatchments.bulletSize + .1f;
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
            return gunAttatchments.bulletRange;
        }
        set
        {
            gunAttatchments.bulletRange = value;
        }
    }
}
