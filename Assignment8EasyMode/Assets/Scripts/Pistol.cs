/*
 * Adam Field
 * Assignment8EasyMode
 * Pistol template
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : ShootGunSuperClass
{
    public GameObject bullet;
    public ParticleSystem particleEffect;

    public override void PlayParticleEffect()
    {
        particleEffect.Play();
    }

    public override void SpawnBullet()
    {
        GameObject holder = Instantiate(bullet);
    }
}
