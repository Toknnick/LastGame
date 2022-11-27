using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _menu;

    public void OpenMenu()
    {
        _menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseMenu()
    {
        _menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitFromLevel()
    {
        PlayerPrefs.SetInt("CountOfOpenLevels", LevelManager.CountOfOpenLevels);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
