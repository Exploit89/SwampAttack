using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    [SerializeField] private Menu _menu;
    [SerializeField] private Button _shopButton;
    [SerializeField] private GameObject _panel;

    private void OnEnable()
    {
        _shopButton.onClick.AddListener(OnShopButtonClick);
    }

    private void OnDisable()
    {
        _shopButton.onClick.RemoveListener(OnShopButtonClick);
    }

    public void OnShopButtonClick()
    {
        _menu.OpenPanel(_panel);
    }
}
