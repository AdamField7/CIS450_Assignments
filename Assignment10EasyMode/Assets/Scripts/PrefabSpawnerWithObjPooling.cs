/*
 * Adam Field
 * Assignment10EasyMode
 * prefab spawner, spawns a bullet when left click is hit
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawnerWithObjPooling : MonoBehaviour
{
    ObjectPooler objectPooler;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.instance;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            objectPooler.SpawnFromPool("Bullet", transform.position, Quaternion.identity);
        }
    }
}
