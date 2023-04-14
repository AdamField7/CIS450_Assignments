/*
 * Adam Field
 * Assignment11EasyMode
 * starts shooting coroutine or stops it for the pistol
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public GameObject bullet;
    public IEnumerator StartShooting()
    {
        while(true)
        {
            Instantiate(bullet);
            yield return new WaitForSeconds(1);
        }
    }

    public void StopShooting()
    {
        StopAllCoroutines();
    }
}
