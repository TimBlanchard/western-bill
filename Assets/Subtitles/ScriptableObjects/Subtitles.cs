using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Subtitle/Subtitles")]
public class Subtitles : ScriptableObject
{

    public delegate void SubtitleEvent(int currentLine);
    public event SubtitleEvent OnSubtitleChange;
    public event SubtitleEvent OnSubtitleDisplayed;

    public static Subtitles instance;

    public List<string> Lines;

    public bool IsDisplayed = false;

    private int _currentLine;

    public int GetCurrentLine(){
        return _currentLine;
    }

    public void StartDisplay(){
        _currentLine = 0;
        Subtitles.instance = this;

    }

    public bool HasNext(){
        return (_currentLine < Lines.Count-1);
    }

    public void Next(){
        if(HasNext()){
            switch (_currentLine) {
                case 0 : 
                SoundManagerScript.PlaySoundAndDisplayLine ("villager");
                break;
                case 1 : 
                SoundManagerScript.PlaySoundAndDisplayLine ("villager");
                break;
                case 2 :
                SoundManagerScript.PlaySoundAndDisplayLine ("akuaku");
                break;
            }
            _currentLine++;
            if(OnSubtitleChange != null) OnSubtitleChange(_currentLine);
        }else{
            IsDisplayed = true;
            if(OnSubtitleDisplayed != null) OnSubtitleDisplayed(_currentLine);
        }
    }

}