/*
 * Adam Field
 * Assignment6EasyMode
 * abstract class to be overwritten, set up creating a gun (adding the prefab and script)
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GunCreator
{
    public abstract GameObject CreateGunPrefab(string type);
    public abstract GameObject AddGunScript(GameObject prefab, string type);
}
