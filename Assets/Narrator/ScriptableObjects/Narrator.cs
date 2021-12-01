using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Narrator/Narrators")]
public class Narrator : ScriptableObject
{

    public delegate void NarratorEvent(int currentLine);
    public event NarratorEvent OnNarratorChange;
    public event NarratorEvent OnNarratorDisplayed;

    public List<string> Lines;

    public bool IsDisplayed = false;

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
        if(HasNext()){
            _currentLine++;
            if(OnNarratorChange != null) OnNarratorChange(_currentLine);
        }else{
            IsDisplayed = true;
            if(OnNarratorDisplayed != null) OnNarratorDisplayed(_currentLine);
        }
    }

}