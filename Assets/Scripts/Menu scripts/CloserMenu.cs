using UnityEngine;

public class CloserMenu : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _portal;
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _defaultTransformForPlayer;

    public void CloseMenu()
    {
        _portal.SetActive(true);
        _player.SetActive(true);
        _player.transform.position = _defaultTransformForPlayer.position;
        _menu.SetActive(false);
        _mainMenu.SetActive(true);
    }
}
