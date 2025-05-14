using UnityEngine;
using System;

public class ColorObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData colorData;
    private SpriteRenderer spriteRenderer;

    public ColorShapeData ColorData => colorData;

    public static event Action<Color> OnChangeColor;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        SetUp();
    }

    private void SetUp()
    {
        spriteRenderer.color = colorData.Color;
        spriteRenderer.sprite = colorData.Sprite;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnChangeColor?.Invoke(colorData.Color);
        }
    }
}
