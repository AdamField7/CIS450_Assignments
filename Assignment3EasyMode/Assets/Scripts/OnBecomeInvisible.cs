/*
 * Adam Field
 * Assignment3EasyMode
 * when an object becomes invisible destroy it
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBecomeInvisible : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
