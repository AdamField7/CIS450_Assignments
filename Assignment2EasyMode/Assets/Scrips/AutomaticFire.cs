/*
 * Adam Field
 * Asignment2EasyMode
 * sets up the auto fire mode
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticFire : ShootBehavior
{
    public override void Shoot(GameObject bullet)
    {
        //shoot constantly while holding click
        Debug.Log("AUTO FIRE");
        Instantiate(bullet);
    }
}
