/*
 * Adam Field
 * Asignment2EasyMode
 * abstract class that sets up shooting bullets
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootBehavior : MonoBehaviour
{
    public abstract void Shoot(GameObject bullet);
}
