/*
 * Adam Field
 * Assignment11EasyMode
 * facade outline for subsystem classes
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManagerFacade : MonoBehaviour
{
    public BoolShootingText boolShootingText;
    public Pistol pistol;
    public Rifle rifle;

    public void StartShooting()
    {
        StartCoroutine(boolShootingText.StartShooting());
        StartCoroutine(pistol.StartShooting());
        StartCoroutine(rifle.StartShooting());

    }

    public void StopShooting()
    {
        StartCoroutine(boolShootingText.StopShooting());
        pistol.StopShooting();
        rifle.StopShooting();
    }
}
