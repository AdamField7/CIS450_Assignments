/*
 * Adam Field
 * Assignment4EasyMode
 * sets up getters and setters for bulletSize, fireRate, bulletRange
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAttatchments
{
    public virtual float bulletSize { set; get; } = .1f;
    public virtual float fireRate { set; get; } = 1f;
    public virtual float bulletRange { set; get; } = 1f;
}
