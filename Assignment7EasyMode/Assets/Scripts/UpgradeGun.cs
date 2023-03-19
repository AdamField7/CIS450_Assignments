/*
 * Adam Field
 * Assignment7EasyMode
 * sets up upgrading guns
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeGun : MonoBehaviour, Command
{
    ChangeGun changeGun;
    Stack<string> changeHistory;

    public UpgradeGun(ChangeGun changeGun)
    {
        this.changeGun = changeGun;
        changeHistory = new Stack<string>();
    }

    public void Execute()
    {
        changeHistory.Push(changeGun.GetCurrentUpgrade());

        changeGun.UpgradeGun();
    }

    public void Undo()
    {
        if (changeHistory.Count != 0)
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
