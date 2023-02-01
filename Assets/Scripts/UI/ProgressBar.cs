using UnityEngine;

public class ProgressBar : Bar
{
    [SerializeField] private Spawner _spawner;

    void OnEnable()
    {
        _spawner.EnemyCountChanged += OnValueChanged;
        Slider.value = 0;
    }

    void OnDisable()
    {
        _spawner.EnemyCountChanged -= OnValueChanged;
    }
}
