/*
 * Adam Field
 * Assignment4EasyMode
 * sets up shooting and changing attributes for firing.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GunAttatchments gunAttatchments;

    private void Awake()
    {
        gunAttatchments = new GunAttatchments();    
    }

    //ADD A WAY TO CALL ADDGUNDECORATOR
    public void ButtonClicked(GameObject gameObject)
    {
        ShopButton shopButton = gameObject.GetComponent<ShopButton>();
        if(shopButton != null)
        {
            AddGunDecorator(shopButton);
        }
    }

    public void AddGunDecorator(ShopButton shopButton)
    {

        switch (shopButton.attatchmentType)
        {
            case ShopButton.AttatchmentType.BIGGERBULLETS:
                gunAttatchments = new BiggerBullets(gunAttatchments);
                break;
            case ShopButton.AttatchmentType.FASTERFIRING:
                gunAttatchments = new FasterFiring(gunAttatchments);
                break;
            case ShopButton.AttatchmentType.LONGERRANGE:
                gunAttatchments = new LongerRange(gunAttatchments);
                break;
            default:
                break;
        }

    }

    private float timer = 0;
    public GameObject bullet;
    public GameObject bulletSpawn;

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if(Time.time >= timer)
        {
            timer = Time.time + gunAttatchments.fireRate;
            bullet.transform.localScale = new Vector3(gunAttatchments.bulletSize, gunAttatchments.bulletSize, gunAttatchments.bulletSize);
            GameObject spawn = Instantiate(bullet, bulletSpawn.transform.position, bullet.transform.rotation);
            Destroy(spawn, gunAttatchments.bulletRange);
            
        }
    }
}
