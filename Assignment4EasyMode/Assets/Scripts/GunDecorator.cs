/*
 * Adam Field
 * Assignment4EasyMode
 * Sets up getters and setters for decorator
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GunDecorator : GunAttatchments
{
    public override abstract float bulletSize { get; set; }
    public override abstract float fireRate { get; set; }
    public override abstract float bulletRange { get; set; }
}
