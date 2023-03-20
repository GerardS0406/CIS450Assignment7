/*
 * Gerard Lamoureux
 * ErasePixelCommand
 * Assignment 7
 * Handles Erasing Pixels Command
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErasePixelCommand : Command
{
    private PixelGrid pixelGrid;
    private int x;
    private int y;

    private Color previousColor;

    public ErasePixelCommand(PixelGrid pixelGrid, int x, int y)
    {
        this.pixelGrid = pixelGrid;
        this.x = x;
        this.y = y;
    }

    public void Execute()
    {
        previousColor = pixelGrid.GetPixel(x, y);
        pixelGrid.SetPixel(x, y, Color.clear);
    }

    public void Undo()
    {
        pixelGrid.SetPixel(x, y, previousColor);
    }
}
