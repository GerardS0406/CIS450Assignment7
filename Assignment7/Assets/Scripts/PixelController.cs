/*
 * Gerard Lamoureux
 * PixelController
 * Assignment 7
 * Handles specific Pixel Objects
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelController : MonoBehaviour
{
    public PixelGrid pixelGrid;

    public int x;
    public int y;

    private bool wasPixelChanged;

    private void OnMouseDown()
    {
        if (DrawingController.thisDrawingController.IsDrawing)
        {
            Command command = new DrawPixelCommand(pixelGrid, x, y, DrawingController.thisDrawingController.Color);
            pixelGrid.ExecuteCommand(command);
            wasPixelChanged = true;
        }
        else
        {
            Command command = new ErasePixelCommand(pixelGrid, x, y);
            pixelGrid.ExecuteCommand(command);
            wasPixelChanged = true;
        }
    }

    private void OnMouseEnter()
    {
        if(Input.GetMouseButton(0))
        {
            if(!wasPixelChanged)
            {
                if (DrawingController.thisDrawingController.IsDrawing)
                {
                    Command command = new DrawPixelCommand(pixelGrid, x, y, DrawingController.thisDrawingController.Color);
                    pixelGrid.ExecuteCommand(command);
                    wasPixelChanged = true;
                }
                else
                {
                    Command command = new ErasePixelCommand(pixelGrid, x, y);
                    pixelGrid.ExecuteCommand(command);
                    wasPixelChanged = true;
                }
            }
        }
    }

    private void OnMouseExit()
    {
        wasPixelChanged = false;
    }
}
