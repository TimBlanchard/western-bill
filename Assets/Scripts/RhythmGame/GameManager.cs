 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
	public AudioSource[] billySounds;
	private AudioSource billySound;
    public bool startPlaying;
	public bool succeedGame;
    public BeatScroller _beatScroller;
	public AudioSource[] hitSounds;
	private AudioSource hitSound;
	public AudioSource tempete;
	public AudioSource ambient;
	public bool isOnLastCamera = false;
	public Animator animator;
    public static GameManager instance;
    public int currentHits;
	public int maxSpeed = 20;
	public float gameSpeed;
	public int notesNumberToImproveSpeed = 2;
	public int gameSpeedToSucceed = 16;
	[SerializeField]
    private CinemachineVirtualCamera nearCamera;
    [SerializeField]
    private CinemachineVirtualCamera farCamera;
	[SerializeField]
    private CinemachineVirtualCamera endCamera;


	 
    public IEnumerator FadeOut (AudioSource audioSource, float FadeTime) {
        float startVolume = audioSource.volume;
 
        while (audioSource.volume > 0) {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
 
            yield return null;
        }
 
        audioSource.Stop ();
        audioSource.volume = startVolume;
    }
 
	

	private void OnEnable()
	{
	CameraSwitcher.Register(nearCamera);
	CameraSwitcher.Register(farCamera);
	CameraSwitcher.Register(endCamera);
	CameraSwitcher.SwitchCamera(nearCamera);
	}

	private void OnDisable()
	{
	CameraSwitcher.Unregister(nearCamera);
	CameraSwitcher.Unregister(farCamera);
	CameraSwitcher.Unregister(endCamera);
	}
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
		if(!succeedGame)
		{
			if(!startPlaying)
        	{
            	if (Input.anyKeyDown)
            	{
                	startPlaying = true;
                	_beatScroller.hasStarted = true;
            	}  
     		}
		}
    }

    public void NoteHit()
    {
        currentHits += 1;
		hitSound = hitSounds[Random.Range(0, hitSounds.Length)];
		hitSound.Play();
		if(currentHits >= notesNumberToImproveSpeed)
		{
			currentHits = 0;
			gameSpeed += 1;
			billySound = billySounds[Random.Range(0, billySounds.Length)];
			billySound.Play();
			if(gameSpeed >= gameSpeedToSucceed)
			{
				succeedGame = true;
				CameraSwitcher.SwitchCamera(farCamera);
				StartCoroutine(EndScene3());
			}
		}			
    }

    public void NoteMissed()
    {
     
    }

	IEnumerator EndScene3()
    {
	 	yield return new WaitForSeconds(10);
		StartCoroutine(FadeOut(ambient, 1.5f));
		tempete.Play();
		yield return new WaitForSeconds(5);
        CameraSwitcher.SwitchCamera(endCamera);
		yield return new WaitForSeconds(5);
        MainController.Instance.ChangeScene(4);
    }
}
