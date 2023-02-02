using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private Menu _menu;
    [SerializeField] private Button _menuButton;
    [SerializeField] private GameObject _panel;

    private void OnEnable()
    {
        _menuButton.onClick.AddListener(OnMenuButtonClick);
    }

    private void OnDisable()
    {
        _menuButton.onClick.RemoveListener(OnMenuButtonClick);
    }

    public void OnMenuButtonClick()
    {
        _menu.OpenPanel(_panel);
    }
}
