/*
 * Adam Field
 * Assignment4EasyMode
 * moves the bullet once it spawns
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(200, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
