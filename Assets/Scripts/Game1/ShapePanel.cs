using UnityEngine;
using UnityEngine.UI;

public class ShapePanel : MonoBehaviour
{
    [SerializeField] private Image shapeImage;

    public void UpdateShape(Sprite newShape)
    {
        shapeImage.sprite = newShape;
    }
}
