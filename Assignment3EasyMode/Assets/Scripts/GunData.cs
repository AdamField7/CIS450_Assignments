/*
 * Adam Field
 * Assignment3EasyMode
 * implements the GunData class which is the concrete subject
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunData : MonoBehaviour, ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    int gun = 1;
    int ammo = 3;

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.UpdateData(ammo, gun);
            Debug.Log("notifyObservers was called from gunData");
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);

        observer.UpdateData(ammo, gun);
    }

    public void RemoveObserver(IObserver observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

    public void ChangeGun(int gun)
    {
        Debug.Log("changeGun was called");
        this.gun = gun;
        NotifyObservers();
    }

    public void ChangeAmmo(int ammo)
    {
        this.ammo = ammo;
        NotifyObservers();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            //change to pistol
            Debug.Log("change to pistol");
            ChangeGun(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //change to rifle
            Debug.Log("change to rifle");
            ChangeGun(2);
        }


        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //change to small ammo
            Debug.Log("change to small ammo");
            ChangeAmmo(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //change to medium ammo
            Debug.Log("change to medium ammo");
            ChangeAmmo(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            //change to large ammo
            Debug.Log("change to large ammo");
            ChangeAmmo(5);
        }
    }
}
