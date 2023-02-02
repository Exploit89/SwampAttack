using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    [SerializeField] private Menu _menu;
    [SerializeField] private Button _continueButton;
    [SerializeField] private GameObject _panel;

    private void OnEnable()
    {
        _continueButton.onClick.AddListener(OnContinueButtonClick);
    }

    private void OnDisable()
    {
        _continueButton.onClick.RemoveListener(OnContinueButtonClick);
    }

    public void OnContinueButtonClick()
    {
        _menu.ClosePanel(_panel);
    }
}
