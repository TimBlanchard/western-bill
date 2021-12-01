 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource _audioSource;
    public bool startPlaying;
    public BeatScroller _beatScroller;

    public static GameManager instance;
    public int currentScore;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                _beatScroller.hasStarted = true;

                _audioSource.Play();
            }
            
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit On Time");
        currentScore += 1;
    }

    public void NoteMissed()
    {
        Debug.Log("Missed");
    }
}
