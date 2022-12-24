using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenerNewLevel : MonoBehaviour
{
    private int _maxLevels = 30;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPrefs.SetInt("CountOfOpenLevels", SaverParametrs.CountOfOpenLevels);

        if (SceneManager.GetActiveScene().buildIndex != _maxLevels)
        {
            if (SceneManager.GetActiveScene().buildIndex == SaverParametrs.CountOfOpenLevels)
                if (SceneManager.GetActiveScene().buildIndex != 30)
                    SaverParametrs.CountOfOpenLevels = SceneManager.GetActiveScene().buildIndex + 1;
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
