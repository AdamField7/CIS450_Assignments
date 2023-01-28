/*
 * Adam Field
 * Asignment2EasyMode
 * abstract class that sets up changing fire mode
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    public ShootBehavior shootBehavior;
    public void SetShootBehavior(ShootBehavior newShootBehavior)
    {
        shootBehavior = newShootBehavior;
    }
}
