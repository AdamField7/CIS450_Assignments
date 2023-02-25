/*
 * Adam Field
 * Assignment6EasyMode
 * Sets up spawning guns, including player input
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpawner : MonoBehaviour
{
    public GunCreator gunCreator;
    public bool gunCreatorIsGood;
    public List<GameObject> goodGuns;
    public List<GameObject> evilGuns;

    // Start is called before the first frame update
    void Start()
    {
        gunCreator = new GoodCreator();
        gunCreatorIsGood = true;
    }

    public GameObject SpawnGun(string type)
    {
        GameObject gun = null;
        gun = gunCreator.CreateGunPrefab(type);

        //set spawn position
        float yRand = Random.Range(-10, 11);
        Vector3 spawnPos = new Vector3(-15, yRand, 12.6f);

        GameObject gunInstance = Instantiate(gun, spawnPos, transform.rotation);
        gunCreator.AddGunScript(gunInstance, type);
        return gunInstance;
    }

    // Update is called once per frame
    void Update()
    {
        //put what buttons to press to spawn things here
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (gunCreatorIsGood)
            {
                gunCreator = new EvilCreator();
                gunCreatorIsGood = false;
            }
            else
            {
                gunCreator = new GoodCreator();
                gunCreatorIsGood = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (gunCreatorIsGood)
            {
                goodGuns.Add(SpawnGun("Pistol"));
            }
            else
            {
                evilGuns.Add(SpawnGun("Pistol"));
            }

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (gunCreatorIsGood)
            {
                goodGuns.Add(SpawnGun("Rifle"));
            }
            else
            {
                evilGuns.Add(SpawnGun("Rifle"));
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (gunCreatorIsGood)
            {
                goodGuns.Add(SpawnGun("RocketLauncher"));
            }
            else
            {
                evilGuns.Add(SpawnGun("RocketLauncher"));
            }
        }
    }
}
