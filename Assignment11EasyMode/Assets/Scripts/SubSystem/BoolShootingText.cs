/*
 * Adam Field
 * Assignment11EasyMode
 * turns on or off the shooting text
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolShootingText : MonoBehaviour
{
    public GameObject shooting;
    public GameObject notShooting;

    public IEnumerator StartShooting()
    {
        StopAllCoroutines();
        notShooting.SetActive(false);

        shooting.SetActive(true);
        yield return new WaitForSeconds(5);
        shooting.SetActive(false);
    }

    public IEnumerator StopShooting()
    {
        StopAllCoroutines();
        shooting.SetActive(false);

        notShooting.SetActive(true);
        yield return new WaitForSeconds(5);
        notShooting.SetActive(false);
    }
}
