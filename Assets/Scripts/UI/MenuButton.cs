using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private Menu _menu;

    public void OnClick()
    {
        _menu.OpenMenu();
    }
}
