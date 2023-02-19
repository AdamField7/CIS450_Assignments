/*
 * Adam Field
 * Assignment5EasyMode
 * gun factory is where the guns are created 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGunFactory : MonoBehaviour
{
    public GameObject pistolPrefab;
    public GameObject riflePrefab;
    public GameObject rocketLauncherPrefab;

    private GameObject gunToSpawn;

    public GameObject CreateGun(string type)
    {
        gunToSpawn = null;

        if (type.Equals("Pistol"))
        {
            gunToSpawn = pistolPrefab;
        }
        else if (type.Equals("Rifle"))
        {
            gunToSpawn = riflePrefab;
        }
        else if (type.Equals("RocketLauncher"))
        {
            gunToSpawn = rocketLauncherPrefab;
        }

        Debug.Log("Factory sending: " + gunToSpawn);
        return gunToSpawn;
    }
}
