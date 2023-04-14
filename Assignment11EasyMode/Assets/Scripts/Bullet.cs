/*
 * Adam Field
 * Assignment11EasyMode
 * Adds a force to the bullet when it spawns, deletes it when it goes off screen.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.right * 1500);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
