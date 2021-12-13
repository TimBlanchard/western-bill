using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomNarratorDisplay : MonoBehaviour
{
    public TextMeshProUGUI _text;
    public static CustomNarratorDisplay instance;

    void Start()
    {
        CustomNarratorDisplay.instance = this;
    }
    
    IEnumerator WaiterDestroyNarrator(string[] narrators, float duration)
    {
        
        foreach (string narrator in narrators)
        {
            _text.text = narrator;
            yield return new WaitForSeconds(duration);
        }

        _text.text = "";

    }

    public void Display(string[] narrators, float duration)
    {
        StartCoroutine(WaiterDestroyNarrator(narrators, duration));
    }
}
