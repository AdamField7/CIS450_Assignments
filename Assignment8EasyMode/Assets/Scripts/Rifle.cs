/*
 * Adam Field
 * Assignment8EasyMode
 * Rifle template
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : ShootGunSuperClass
{
    public GameObject bullet;
    public ParticleSystem particleEffect;

    public override void PlayParticleEffect()
    {
        particleEffect.Play();
    }

    public override void SpawnBullet()
    {
        Instantiate(bullet);
    }
}
