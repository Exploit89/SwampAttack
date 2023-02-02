using UnityEngine;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private Menu _menu;

    public void OnClick()
    {
        _menu.CloseShop();
    }
}
