/*
 * Adam Field
 * Assignment3EasyMode
 * implements the gun class which is the concrete observer
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IObserver
{
    public GunData gunData;

    //1 == pistol, 2 == rifle
    int gun;

    //3 == small, 4 == medium, 5 == large
    int ammo;

    //GameObject gunHolder;
    public GameObject rifle;
    public GameObject pistol;

    GameObject ammoHolder;
    public GameObject smallAmmo;
    public GameObject mediumAmmo;
    public GameObject largeAmmo;

    Vector3 spawnPoint;
    public GameObject pistolSpawnPoint;
    public GameObject rifleSpawnPoint;

    public void UpdateData(int gun, int ammo)
    {

        Debug.Log("update data");
        this.ammo = ammo;
        this.gun = gun;

        UpdateGun();
        UpdateAmmo();
    }

    public void Shoot()
    {
        Debug.Log("Shoot");

        GameObject shot = Instantiate(ammoHolder, spawnPoint, transform.rotation);

        shot.GetComponent<Rigidbody>().AddForce(transform.right * 500);
    }

    void UpdateGun()
    {
        Debug.Log("update gun was called");
        if (gun == 1)
        {
            rifle.SetActive(false);
            pistol.SetActive(true);
            spawnPoint = pistolSpawnPoint.transform.position;
        }
        else if(gun == 2)
        {
            pistol.SetActive(false);
            rifle.SetActive(true);
            spawnPoint = rifleSpawnPoint.transform.position;
        }
    }

    void UpdateAmmo()
    {
        Debug.Log("update ammo was called");
        if(ammo == 3)
        {
            ammoHolder = smallAmmo;
        }
        else if(ammo == 4)
        {
            ammoHolder = mediumAmmo;
        }
        else if(ammo == 5)
        {
            ammoHolder = largeAmmo;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gunData.RegisterObserver(this);
        //pistol.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
}
