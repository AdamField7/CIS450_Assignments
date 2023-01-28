/*
 * Adam Field
 * Asignment2EasyMode
 * adds a force to the bullet when it spawns
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(900, 0, 0));
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
