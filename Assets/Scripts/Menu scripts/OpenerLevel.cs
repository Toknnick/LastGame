using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenerLevel : MonoBehaviour
{
    public void OpenLevel()
    {
        int numberOfLevel = Int32.Parse(name);
        SceneManager.LoadScene(numberOfLevel);
    }
}
