/*
 * Gerard Lamoureux
 * ColorButton
 * Assignment 7
 * Handles the color buttons
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public Color Color = new Color();

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetPenColor);
    }

    private void SetPenColor()
    {
        DrawingController.thisDrawingController.SetIsDrawing(true);
        DrawingController.thisDrawingController.SetDrawingColor(Color);
    }
}
