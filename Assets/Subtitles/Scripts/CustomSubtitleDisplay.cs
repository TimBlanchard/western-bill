using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomSubtitleDisplay : MonoBehaviour
{
    public TextMeshProUGUI _text;
    public static CustomSubtitleDisplay instance;

    void Start()
    {
        instance = this;
    }
    
    IEnumerator WaiterDestroySubtitle(string[] subtitles, float duration)
    {
        
        foreach (string subtitle in subtitles)
        {
            _text.text = subtitle;
            yield return new WaitForSeconds(duration);
        }

        _text.text = "";

    }

    public void Display(string[] subtitles, float duration)
    {
        StartCoroutine(WaiterDestroySubtitle(subtitles, duration));
    }
}
