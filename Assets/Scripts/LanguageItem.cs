using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageItem : MonoBehaviour
{
    [SerializeField] private string _rus;
    [SerializeField] private string _eng;

    void Start()
    {
        TextMeshPro text = GetComponent<TextMeshPro>();
        string language = PlayerPrefs.GetString("Language");

        if (language == "" || language == "Rus")
            text.text = _rus;
        else
            text.text = _eng;
    }
}
