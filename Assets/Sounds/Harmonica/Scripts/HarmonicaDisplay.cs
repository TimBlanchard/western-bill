using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HarmonicaDisplay : MonoBehaviour
{
    public Harmonica harmonica;
    private TextMeshProUGUI _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        harmonica.StartDisplay();
        harmonica.OnHarmonicaDisplayed += OnDisplayed;
        _text.text = harmonica.Lines[harmonica.GetCurrentLine()];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.R)){
            harmonica.Next();
            if(!harmonica.IsDisplayed){
                _text.text = harmonica.Lines[harmonica.GetCurrentLine()];
            }
        }
    }

    private void OnDisplayed(int line){
        _text.enabled=false;
    }
}
