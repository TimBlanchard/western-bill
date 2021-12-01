using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NarratorDisplay : MonoBehaviour
{
    public Narrator narrator;
    private Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        narrator.StartDisplay();
        narrator.OnNarratorDisplayed += OnDisplayed;
        _text.text = narrator.Lines[narrator.GetCurrentLine()];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            narrator.Next();
            if(!narrator.IsDisplayed){
                _text.text = narrator.Lines[narrator.GetCurrentLine()];
            }
        }
    }

    private void OnDisplayed(int line){
        _text.enabled=false;
    }
}