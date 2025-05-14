using UnityEngine;

public class PlayerColorShapeController : MonoBehaviour
{
    [SerializeField] private ColorShapeData playerData;

    [SerializeField] private ColorPanel colorPanel;
    [SerializeField] private ShapePanel shapePanel;

    private SpriteRenderer spriteRenderer;

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
        UpdateColor(playerData.Color);
        UpdateShape(playerData.Sprite);
    }

    private void UpdateColor(Color newColor)
    {
        playerData.SetColor(newColor);
        spriteRenderer.color = newColor;
        colorPanel?.UpdateColor(newColor);
    }

    private void UpdateShape(Sprite newSprite)
    {
        playerData.SetSprite(newSprite);
        spriteRenderer.sprite = newSprite;
        shapePanel?.UpdateShape(newSprite);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Color"))
        {
            ColorObject colorObj = other.GetComponent<ColorObject>();
            if (colorObj != null)
            {
                UpdateColor(colorObj.ColorData.Color);
            }
        }

        if (other.CompareTag("Shape"))
        {
            ShapeObject shapeObj = other.GetComponent<ShapeObject>();
            if (shapeObj != null)
            {
                UpdateShape(shapeObj.ShapeData.Sprite);
            }
        }
    }
}
