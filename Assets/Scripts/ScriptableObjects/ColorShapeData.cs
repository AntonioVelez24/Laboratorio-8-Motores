using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorShapeData", menuName = "ScriptableObjects/Game1/ColorShapeData")]

public class ColorShapeData : ScriptableObject
{
    [SerializeField] private Color color;
    [SerializeField] private Sprite sprite;

    public Color Color => color;
    public Sprite Sprite => sprite;

    public void SetColor(Color newColor)
    {
        color = newColor;
    }
    public void SetSprite(Sprite newSprite)
    {
        sprite = newSprite;
    }
}
