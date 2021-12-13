using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class TransitionController : Singleton<TransitionController>
{
    public delegate void TransitionControllerEvent();
    public event TransitionControllerEvent OnTransitionEnds;
    public CanvasGroup canvasGroup;
    private VideoPlayer player;
    public VideoClip[] Clips;

    private bool isStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<VideoPlayer> ();
        canvasGroup.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isStarted && !player.isPlaying) {
            isStarted = false;
            OnTransitionEnds?.Invoke();
            canvasGroup.alpha = 0;
        }
    }

    public void StartTransition(int clipId) {

        isStarted = true;
        player.clip = Clips[clipId];
        player.Play();
        canvasGroup.alpha = 1;
        StartCoroutine(Waiter());
    }

        public IEnumerator Waiter()
    {
        yield return new WaitForSeconds(8);

        player.Stop();
        
    }

}
