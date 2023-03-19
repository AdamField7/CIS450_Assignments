/*
 * Adam Field
 * Assignment7EasyMode
 * sets up downgrading guns 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DowngradeGun : MonoBehaviour, Command
{
    ChangeGun changeGun;
    Stack<string> changeHistory;

    public DowngradeGun(ChangeGun changeGun)
    {
        this.changeGun = changeGun;
        changeHistory = new Stack<string>();
    }

    public void Execute()
    {
        changeHistory.Push(changeGun.GetCurrentUpgrade());

        changeGun.DowngradeGun();
    }

    public void Undo()
    {
        if(changeHistory.Count != 0)
        {
            changeGun.gameObject.tag = changeHistory.Pop();

            if (changeGun.gameObject.tag == "Pistol")
            {
                Destroy(changeGun.thingToBeDeleted);
                changeGun.thingToBeDeleted = Instantiate(changeGun.pistolPrefab);
            }
            if (changeGun.gameObject.tag == "Rifle")
            {
                Destroy(changeGun.thingToBeDeleted);
                changeGun.thingToBeDeleted = Instantiate(changeGun.riflePrefab);
            }
            if (changeGun.gameObject.tag == "RocketLauncher")
            {
                Destroy(changeGun.thingToBeDeleted);
                changeGun.thingToBeDeleted = Instantiate(changeGun.rocketLauncherPrefab);
            }
        }
    }
}
