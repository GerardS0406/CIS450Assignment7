/*
 * Gerard Lamoureux
 * Canvas Background
 * Assignment 7
 * Handles the background color
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasBackground : MonoBehaviour
{
    public PixelGrid pixelGrid;

    public static CanvasBackground thisCanvasBackground;

    private void Awake()
    {
        thisCanvasBackground = this;
        Camera.main.backgroundColor = Color.gray;
    }

    public Color GetColor()
    {
        return Camera.main.backgroundColor;
    }

    public void SetColor(Color color)
    {
        Camera.main.backgroundColor = color;
    }

    public void ExecuteBackgroundChange(Color color)
    {
        Command command = new DrawBackgroundCommand(this, color);
        pixelGrid.ExecuteCommand(command);
    }
}
