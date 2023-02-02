using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    [SerializeField] private Menu _menu;

    public void OnClick()
    {
        _menu.CloseMenu();
    }
}
