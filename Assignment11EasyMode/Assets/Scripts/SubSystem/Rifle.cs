/*
 * Adam Field
 * Assignment11EasyMode
 * starts shooting coroutine or stops it for the rifle
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    public GameObject bullet;
    public IEnumerator StartShooting()
    {
        while (true)
        {
            Instantiate(bullet);
            yield return new WaitForSeconds(0.5f);
        }
    }

    public void StopShooting()
    {
        StopAllCoroutines();
    }
}
