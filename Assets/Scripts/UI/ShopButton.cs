using UnityEngine;

public class ShopButton : MonoBehaviour
{
    [SerializeField] private Menu _menu;

    public void OnClick()
    {
        _menu.OpenShop();
    }
}
