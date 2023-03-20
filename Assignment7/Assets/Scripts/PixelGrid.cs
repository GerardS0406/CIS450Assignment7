/*
 * Gerard Lamoureux
 * PixelGrid
 * Assignment 7
 * Handles the drawing canvas and also handles command history stack
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelGrid : MonoBehaviour
{
    public int width;
    public int height;
    public float pixelSize;
    public GameObject pixelPrefab;

    public Color[] pixels;
    private Stack<Command> commandHistory = new Stack<Command>();

    private void Awake()
    {
        transform.position = new Vector2(-(width * pixelSize) / 2, -(height * pixelSize) / 2);

        pixels = new Color[width * height];

        for(int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
                CreatePixel(x, y);
        }
    }

    private void CreatePixel(int x, int y)
    {
        GameObject pixel = Instantiate(pixelPrefab, transform);
        pixel.transform.localPosition = new Vector2(x * pixelSize, y * pixelSize);
        pixel.transform.localScale = new Vector2(pixelSize, pixelSize);

        PixelController pixelController = pixel.GetComponent<PixelController>();
        pixelController.pixelGrid = this;
        pixelController.x = x;
        pixelController.y = y;
        SetPixel(x, y, Color.white);
    }

    public void SetPixel(int x, int y, Color color)
    {

        pixels[x * height + y] = color;
        Transform pixelTransform = transform.GetChild(x * height + y);
        pixelTransform.GetComponent<SpriteRenderer>().color = color;
    }

    public Color GetPixel(int x, int y)
    {
        return pixels[x * height + y];
    }

    public void ExecuteCommand(Command command)
    {
        command.Execute();
        commandHistory.Push(command);
    }

    public void UndoLastCommand()
    {
        if(commandHistory.Count > 0)
        {
            Command command = commandHistory.Pop();
            command.Undo();
        }
    }
}
