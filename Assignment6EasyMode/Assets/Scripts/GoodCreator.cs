/*
 * Adam Field
 * Assignment6EasyMode
 * sets up creating good gun
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodCreator : GunCreator
{
    private GameObject goodPrefab;

    public override GameObject CreateGunPrefab(string type)
    {
        if (type.Equals("Pistol"))
        {
            goodPrefab = Resources.Load<GameObject>("Pistol");
        }
        else if (type.Equals("Rifle"))
        {
            goodPrefab = Resources.Load<GameObject>("Rifle");
        }
        else if (type.Equals("RocketLauncher"))
        {
            goodPrefab = Resources.Load<GameObject>("RocketLauncher");
        }

        return goodPrefab;
    }

    public override GameObject AddGunScript(GameObject prefab, string type)
    {
        if (type.Equals("Pistol"))
        {
            if (prefab.GetComponent<GoodPistol>() == null)
            {
                prefab.AddComponent<GoodPistol>();
            }
        }
        else if (type.Equals("Rifle"))
        {
            if (prefab.GetComponent<GoodRifle>() == null)
            {
                prefab.AddComponent<GoodRifle>();
            }

        }
        else if (type.Equals("RocketLauncher"))
        {
            if (prefab.GetComponent<GoodRocketLauncher>() == null)
            {
                prefab.AddComponent<GoodRocketLauncher>();
            }
        }

        return prefab;
    }
}
