/*
 * Adam Field
 * Assignment 1
 * console output class, attactched to cube in sample scene
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleOutput : MonoBehaviour
{
    RocketLauncher rocketLauncher1 = new RocketLauncher();
    RocketLauncher rocketLauncher2 = new RocketLauncher();
    Pistol pistol1 = new Pistol();
    Pistol pistol2 = new Pistol();
    Rifle rifle = new Rifle();

    List<Item> items = new List<Item>();

    List<Gun> guns = new List<Gun>();

    // Start is called before the first frame update
    void Start()
    {
        items.Add(pistol1);
        items.Add(pistol2);
        items.Add(rocketLauncher1);
        items.Add(rocketLauncher2);

        guns.Add(pistol1);
        guns.Add(rocketLauncher1);

        items.Add(rifle);
        guns.Add(rifle);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Item i in items)
            {
                i.GetWeight();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (Gun g in guns)
            {
                g.Shoot();
            }
        }
    }
}
