using UnityEngine;

public class HealthBar : Bar
{
    [SerializeField] private Player _player;

    void OnEnable()
    {
        _player.HealthChanged += OnValueChanged;
        Slider.value = 1;
    }

    void OnDisable()
    {
        _player.HealthChanged -= OnValueChanged;
    }
}
