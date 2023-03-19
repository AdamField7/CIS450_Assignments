/*
 * Adam Field
 * Assignment7EasyMode
 * The invoker for the command design pattern
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunUpgradeManagerInvoker : MonoBehaviour
{
    public ChangeGun changeGun;
    private Command upgradeGun;
    private Command downgradeGun;
    public Stack<Command> commandHistory;


    // Start is called before the first frame update
    void Start()
    {
        upgradeGun = new UpgradeGun(changeGun);
        downgradeGun = new DowngradeGun(changeGun);
        commandHistory = new Stack<Command>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            upgradeGun.Execute();
            commandHistory.Push(upgradeGun);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            downgradeGun.Execute();
            commandHistory.Push(downgradeGun);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(commandHistory.Count != 0)
            {
                Command lastCommand = commandHistory.Pop();

                lastCommand.Undo();
            }
        }
    }
}
