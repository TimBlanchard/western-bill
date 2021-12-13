using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoController : Singleton<VideoController>
{
    public delegate void VideoControllerEvent(string video);
    public event VideoControllerEvent OnOpenVideo;
    public event VideoControllerEvent OnCloseVideo;
    public int timeToStop;
    public GameObject videoPlayer1, videoPlayer2, videoPlayer3, videoPlayer4;
    public Camera camera1, camera2;
    // private VideoPlayer videoPlayer;


	public void Starting () {
        videoPlayer1 = GameObject.Find("VideoPlayer1");
        videoPlayer2 = GameObject.Find("VideoPlayer2");
        videoPlayer3 = GameObject.Find("VideoPlayer3");
        videoPlayer4 = GameObject.Find("VideoPlayer4");
        videoPlayer1.SetActive(false);
        videoPlayer2.SetActive(false);
        videoPlayer3.SetActive(false);
        videoPlayer4.SetActive(false);
        
        // Camera camera = Camera.main;
	}
	public void OnPlayVideo (string id) {
        Debug.Log("hmmmm");
        Debug.Log(id);

        switch (id) {
            case "1":
                videoPlayer1.SetActive(true);
                // videoPlayer1.play();
                // videoPlayer1 = GetComponent<Camera>().AddComponent<UnityEngine.Video.VideoPlayer>();
                // Destroy(videoPlayer1, timeToStop);
            break;
            case "2":
                videoPlayer2.SetActive(true);
                // Destroy(videoPlayer2, timeToStop);
                break;
            case "3":
                videoPlayer3.SetActive(true);
                // Destroy(videoPlayer3, timeToStop);
                break;
            case "4":
                videoPlayer4.SetActive(true);
                // Destroy(videoPlayer4, timeToStop);
                break;
        }
        
	}
}