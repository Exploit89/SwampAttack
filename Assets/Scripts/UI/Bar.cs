using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] protected Slider Slider;

    public void OnValueChanged(int value, int maxvalue)
    {
        Slider.value = (float)value / maxvalue;
    }
}
