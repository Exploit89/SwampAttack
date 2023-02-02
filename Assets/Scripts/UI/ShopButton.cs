using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    [SerializeField] private Menu _menu;
    [SerializeField] private Button _shopButton;
    [SerializeField] private GameObject _panel;

    private void OnEnable()
    {
        _shopButton.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _shopButton.onClick.RemoveListener(OnClick);
    }

    public void OnClick()
    {
        _menu.OpenPanel(_panel);
    }
}
