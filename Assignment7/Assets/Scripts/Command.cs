/*
 * Gerard Lamoureux
 * Command
 * Assignment 7
 * Interface to be used by commands
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
    public void Execute();
    public void Undo();
}
