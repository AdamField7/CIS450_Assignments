/*
 * Adam Field
 * Assignment7EasyMode
 * holds the gameobjects to spawn and despawn
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGun : MonoBehaviour
{
    public GameObject currentGameObject;
    public GameObject pistolPrefab;
    public GameObject riflePrefab;
    public GameObject rocketLauncherPrefab;
    public GameObject thingToBeDeleted;

    private void Start()
    {
        gameObject.tag = "Pistol";
        thingToBeDeleted = Instantiate(pistolPrefab);
    }

    public string GetCurrentUpgrade()
    {
        return currentGameObject.tag;
    }

    public void UpgradeGun()
    {
        if(currentGameObject.tag == "Pistol")
        {
            gameObject.tag = "Rifle";
            Destroy(thingToBeDeleted);
            thingToBeDeleted = Instantiate(riflePrefab);
        }
        else if(currentGameObject.tag == "Rifle")
        {
            gameObject.tag = "RocketLauncher";
            Destroy(thingToBeDeleted);
            thingToBeDeleted = Instantiate(rocketLauncherPrefab);
        }
        else if(currentGameObject.tag == "RocketLauncher")
        {
            Debug.Log("Cant Upgrade a Rocket Launcher");
        }
    }

    public void DowngradeGun()
    {
        if (currentGameObject.tag == "Pistol")
        {
            Debug.Log("Cant Downgrade a pistol");
        }
        else if (currentGameObject.tag == "Rifle")
        {
            gameObject.tag = "Pistol";
            Destroy(thingToBeDeleted);
            thingToBeDeleted = Instantiate(pistolPrefab);
        }
        else if (currentGameObject.tag == "RocketLauncher")
        {
            gameObject.tag = "Rifle";
            Destroy(thingToBeDeleted);
            thingToBeDeleted = Instantiate(riflePrefab);
        }
    }
}
