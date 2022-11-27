using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _levels;
    [SerializeField] private GameObject _portal;
    [SerializeField] private GameObject _player;

    public void ChooseLevel()
    {
        _menu.SetActive(false);
        _player.SetActive(false);
        _portal.SetActive(false);
        _levels.SetActive(true);
    }
}
