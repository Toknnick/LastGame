using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageItemForButton : MonoBehaviour
{
    [SerializeField] private string _rus;
    [SerializeField] private string _eng;
    [SerializeField] private TMP_Text _text;

    void Start()
    {
        string language = PlayerPrefs.GetString("Language");

        if (language == "Eng")
            _text.text = _eng;
        else 
            _text.text = _rus;
    }
}
