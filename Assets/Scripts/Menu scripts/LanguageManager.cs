using UnityEngine;
using UnityEngine.SceneManagement;

public class LanguageManager : MonoBehaviour
{
    public void SetRussian()
    {
        string language = "Rus";
        PlayerPrefs.SetString("Language", language);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetEnglish()
    {
        string language = "Eng";
        PlayerPrefs.SetString("Language", language);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
