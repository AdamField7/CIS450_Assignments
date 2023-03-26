/*
 * Adam Field
 * Assignment8EasyMode
 * adds force to bullet when it spawns and destroys it when it goes off screen
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
        rb.AddForce(transform.right * 1000);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
