using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    [SerializeField] private Image colorImage;

    public void UpdateColor(Color newColor)
    {
        colorImage.color = newColor;
    }
}
