/*
 * Adam Field
 * Assignment10EasyMode
 * adds a force to the bullet when it spawns
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForce : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = new Vector3(0, 0, 0);
        rb.AddForce(transform.right * 1500);
    }
}
