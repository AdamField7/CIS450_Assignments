/*
 * Adam Field
 * Assignment3EasyMode
 * implements the isubject interface
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
