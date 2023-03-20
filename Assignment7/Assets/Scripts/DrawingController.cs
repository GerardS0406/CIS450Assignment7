/*
 * Gerard Lamoureux
 * Canvas Background
 * Assignment 7
 * Handles brush colors and if drawing or erasing
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingController : MonoBehaviour
{
    public Color Color = new Color(1, 1, 1);

    public bool IsDrawing = true;

    public static DrawingController thisDrawingController;

    private void Awake()
    {
        thisDrawingController = this;
    }

    public void SetDrawingColor(Color color)
    {
        this.Color = color;
    }

    public void SetIsDrawing(bool isDrawing)
    {
        IsDrawing = isDrawing;
    }    
}
