/*
 * Gerard Lamoureux
 * DrawPixelCommand
 * Assignment 7
 * Handles Drawing on Pixels Command
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPixelCommand : Command
{
    private PixelGrid pixelGrid;
    private int x;
    private int y;
    private Color color;

    private Color previousColor;

    public DrawPixelCommand(PixelGrid pixelGrid, int x, int y, Color color)
    {
        this.pixelGrid = pixelGrid;
        this.x = x;
        this.y = y;
        this.color = color;
    }

    public void Execute()
    {
        previousColor = pixelGrid.GetPixel(x, y);
        pixelGrid.SetPixel(x, y, color);
    }

    public void Undo()
    {
        pixelGrid.SetPixel(x, y, previousColor);
    }
}
