using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _shop;
    [SerializeField] private GameObject _menu;

    public void OpenMenu()
    {
        _menu.gameObject.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("1");
    }

    public void CloseMenu()
    {
        _menu.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("0");
    }

    public void OpenShop()
    {
        _shop.gameObject.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("1");
    }

    public void CloseShop()
    {
        _shop.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("0");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
