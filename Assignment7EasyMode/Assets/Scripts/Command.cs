/*
 * Adam Field
 * Assignment7EasyMode
 * interface for the command design pattern
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
    void Execute();
    void Undo();
}
