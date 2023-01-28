/*
 * Adam Field
 * Asignment2EasyMode
 * sets up the single fire mode
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleFire : ShootBehavior
{
    public override void Shoot(GameObject bullet)
    {
        //shoot once per click
        Debug.Log("SINGLE FIRE");
        Instantiate(bullet);
    }
}
