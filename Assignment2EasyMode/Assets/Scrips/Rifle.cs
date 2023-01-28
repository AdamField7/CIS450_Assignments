/*
 * Adam Field
 * Asignment2EasyMode
 * Controls when a bullet is spawned and what kind of firing mode
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Gun
{
    public GameObject bullet;
    bool autoFire;
    bool singleFire;

    private void Start()
    {
        //shootBehavior = new SingleFire();
        shootBehavior = gameObject.AddComponent<SingleFire>();
        singleFire = true;
        autoFire = false;
        //Instantiate(bullet);

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("CLICKED 1");
            Destroy(gameObject.GetComponent<ShootBehavior>());
            shootBehavior = gameObject.AddComponent<SingleFire>();
            singleFire = true;
            autoFire = false;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("CLICKED 2");
            Destroy(gameObject.GetComponent<ShootBehavior>());
            shootBehavior = gameObject.AddComponent<AutomaticFire>();
            singleFire = false;
            autoFire = true;
        }
        if(Input.GetKeyDown(KeyCode.Mouse0) && singleFire)
        {
            shootBehavior.Shoot(bullet);
        }
        else if(Input.GetKey(KeyCode.Mouse0) && autoFire)
        {
            shootBehavior.Shoot(bullet);
        }
    }
}
