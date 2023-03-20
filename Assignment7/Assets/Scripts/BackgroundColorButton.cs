/*
 * Gerard Lamoureux
 * BackgroundColorButton
 * Assignment 7
 * Handles the background color buttons
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundColorButton: MonoBehaviour
{
    public Color Color = new Color();

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetBackColor);
    }

    private void SetBackColor()
    {
        Debug.Log(Color);
        CanvasBackground.thisCanvasBackground.ExecuteBackgroundChange(Color);
    }
}
