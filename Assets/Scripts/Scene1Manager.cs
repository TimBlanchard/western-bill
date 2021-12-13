using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Manager : MonoBehaviour
{
    
    public AudioSource axe;
    public AudioSource reward1AudioOnClick;
    public AudioSource startAudio;
	public AudioSource endAudio;
	public bool isRewardSelected = false;
    public static Scene1Manager instance;
    
    
    IEnumerator WaiterStartDelay()
    {
        yield return new WaitForSeconds(3);
        startAudio.Play();
        string[] subtitles = { "Content de te revoir Billy, ça faisait longtemps qu'on t'avait pas vu ici.", "tu chasses qui cette fois ?" };
        CustomSubtitleDisplay.instance.Display(subtitles, 3f);
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        StartCoroutine(WaiterStartDelay());
    }

	public void EndScene() {
		string[] endSubtitle = { "2 mois que le maire sort plus de chez lui Billy", "Ramène moi ces putains de bottes !" };
        CustomSubtitleDisplay.instance.Display(endSubtitle, 3f);
		endAudio.Play();
        StartCoroutine(ChangeScene2StartDelay());

	}

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ChangeScene2StartDelay()
    {
        yield return new WaitForSeconds(6);
        MainController.Instance.ChangeScene(2);
    }


}
