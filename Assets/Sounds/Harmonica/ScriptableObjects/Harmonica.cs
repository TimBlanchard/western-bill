using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Harmonica/Harmonicas")]
public class Harmonica : ScriptableObject
{

    public delegate void HarmonicaEvent(int currentLine);
    public event HarmonicaEvent OnHarmonicaChange;
    public event HarmonicaEvent OnHarmonicaDisplayed;

    public List<string> Lines;

    public bool IsDisplayed = false;

    private int _currentCount;
    private int _currentLine;

    public int GetCurrentLine(){
        return _currentLine;
    }

    public void StartDisplay(){
        _currentLine = 0;
    }

    public bool HasNext(){
        return (_currentLine < Lines.Count-1);
    }

    public void Next(){
        SoundManagerScript.PlayHarmonicaNote();
        _currentCount++;
        if(HasNext() && _currentCount % 5 == 0) {
            _currentLine++;
            Debug.Log(_currentCount);
            IsDisplayed = true;
        if(OnHarmonicaChange != null) OnHarmonicaChange(_currentLine);
        }
    }

}