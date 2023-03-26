/*
 * Adam Field
 * Assignment8EasyMode
 * gun template
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootGunSuperClass : MonoBehaviour
{
    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ShootGun();
        }
    }

    public void ShootGun()
    {
        PlayParticleEffect();
        SpawnBullet();
    }

    public abstract void PlayParticleEffect();

    public abstract void SpawnBullet();


}
