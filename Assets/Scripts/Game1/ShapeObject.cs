using UnityEngine;
using System;

public class ShapeObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData shapeData;
    private SpriteRenderer spriteRenderer;

    public ColorShapeData ShapeData => shapeData;

    public static event Action<Sprite> OnChangeShape;
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
        spriteRenderer.color = shapeData.Color;
        spriteRenderer.sprite = shapeData.Sprite;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnChangeShape?.Invoke(shapeData.Sprite);
        }
    }
}
