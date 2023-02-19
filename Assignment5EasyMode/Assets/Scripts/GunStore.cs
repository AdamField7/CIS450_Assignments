/*
 * Adam Field
 * Assignment5EasyMode
 * the gun store is where the guns are spawned 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunStore : MonoBehaviour
{
    public SimpleGunFactory factory;
    private GameObject gun;

    public void SpawnGun(string type)
    {
        Debug.Log("Type passed in: " + type);
        gun = factory.CreateGun(type);
        Debug.Log(gun);


        float yRand = Random.Range(-10, 11);
        Vector3 spawnPos = new Vector3(-15, yRand, 12.6f);
        GameObject gunInstance = Instantiate(gun, spawnPos, transform.rotation);


        if (type.Equals("Pistol"))
        {
            gunInstance.AddComponent<Pistol>();
        }
        else if (type.Equals("Rifle"))
        {
            gunInstance.AddComponent<Rifle>();
        }
        else if (type.Equals("RocketLauncher"))
        {
            gunInstance.AddComponent<RocketLauncher>();
        }


    }
}
