/*
 * Adam Field
 * Assignment6EasyMode
 * sets up evil creator
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilCreator : GunCreator
{
    private GameObject evilPrefab;

    public override GameObject CreateGunPrefab(string type)
    {
        if (type.Equals("Pistol"))
        {
            evilPrefab = Resources.Load<GameObject>("Pistol");
        }
        else if (type.Equals("Rifle"))
        {
            evilPrefab = Resources.Load<GameObject>("Rifle");
        }
        else if (type.Equals("RocketLauncher"))
        {
            evilPrefab = Resources.Load<GameObject>("RocketLauncher");
        }

        return evilPrefab;
    }

    public override GameObject AddGunScript(GameObject prefab, string type)
    {
        if (type.Equals("Pistol"))
        {
            if (prefab.GetComponent<EvilPistol>() == null)
            {
                prefab.AddComponent<EvilPistol>();
            }
        }
        else if (type.Equals("Rifle"))
        {
            if (prefab.GetComponent<EvilRifle>() == null)
            {
                prefab.AddComponent<EvilRifle>();
            }

        }
        else if (type.Equals("RocketLauncher"))
        {
            if (prefab.GetComponent<EvilRocketLauncher>() == null)
            {
                prefab.AddComponent<EvilRocketLauncher>();
            }
        }

        return prefab;
    }
}
