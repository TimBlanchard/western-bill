using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class HorseTrigger : MonoBehaviour
{
    private bool triggered = false;

    [SerializeField]
    private CinemachineFreeLook playerCam;
    [SerializeField]
    private CinemachineVirtualCamera horseCam;

    // Start is called before the first frame update

    void Start() {
        playerCam.Priority = 11;
    }
    void OnTriggerEnter(Collider other)
    {
        if(!triggered) {
            triggered = true;
            playerCam.Priority = 0;

            StartCoroutine(WaiterVoice());
            StartCoroutine(Waiter());
        }
    }

    public IEnumerator Waiter()
    {
        yield return new WaitForSeconds(4);

        MainController.Instance.ChangeScene(3);
    }
    public IEnumerator WaiterVoice()
    {
        yield return new WaitForSeconds(2);

        SoundManagerScript.PlayVoice ("scene2", "rat");
        string[] subtitles = { "Villageois 5 : Tema la taille du rat !" };

        CustomSubtitleDisplay.instance.Display(subtitles, 5f);
    }

}
