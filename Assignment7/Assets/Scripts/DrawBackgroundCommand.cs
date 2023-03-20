/*
 * Gerard Lamoureux
 * DrawBackgroundCommand
 * Assignment 7
 * Handles the background color command
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBackgroundCommand : Command
{
    private CanvasBackground canvasBackground;
    private Color color;

    private Color previousColor;

    public DrawBackgroundCommand(CanvasBackground canvasBackground, Color color)
    {
        this.canvasBackground = canvasBackground;
        this.color = color;
    }

    public void Execute()
    {
        previousColor = canvasBackground.GetColor();
        canvasBackground.SetColor(color);
    }

    public void Undo()
    {
        canvasBackground.SetColor(previousColor);
    }
}
