using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class HoverReward : MonoBehaviour
{
    public float overSize;
    public float overDuration;
    public AudioSource audioData;
    public bool axeInteration = false;
    public AudioSource audioInteraction = null;
    public AudioSource goodRewardInteraction = null;
    private GameObject childObj;
    private Collider coll;
    public Animator axeAnimator;

    private bool isDisable = false;
    private bool isSelected = false;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        childObj = gameObject.transform.GetChild(0).gameObject;
        coll = GetComponent<BoxCollider>();
    }

    private void OnMouseEnter()
    {
        if (isDisable == false && Scene1Manager.instance.isRewardSelected  == false)
        {
            childObj.layer = 10;
            CursorHandler.instance.Clickable();
            transform.DOScale(new Vector3( overSize, overSize, 1f), overDuration);
            audioData.Play();   
        }
    }

    private void UnselectObject()
    {
        if (Scene1Manager.instance.isRewardSelected == false)
        {
        childObj.layer = 0;
        CursorHandler.instance.Default();
        transform.DOScale(new Vector3( 1f, 1f, 1f), overDuration);
        }
        audioData.Stop();
    }
    private void OnMouseExit()
    {
        UnselectObject();
    }
    
    IEnumerator EndWaiter(){
        yield return new WaitForSeconds(3);
        Scene1Manager.instance.EndScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (coll.Raycast(ray, out hit, 100))
            {
                if(axeInteration && isDisable == false && Scene1Manager.instance.isRewardSelected == false)
                {
                    axeAnimator.SetBool("isTrigger", true);
                    UnselectObject();
                    string[] subtitles = { "Celui-là est pour moi les gars", "Blake a cassé la gueule de mon cousin" };
                    CustomSubtitleDisplay.instance.Display(subtitles, 2.5f);
                    Scene1Manager.instance.reward1AudioOnClick.Play();
                    Scene1Manager.instance.axe.Play();
                    isDisable = true;
                }
                else if(audioInteraction != null && Scene1Manager.instance.isRewardSelected == false)
                {
                    string[] billyNope = { "Un peu trop simple celle-là" };
                    CustomSubtitleDisplay.instance.Display(billyNope, 3f);
                    UnselectObject();
                    audioInteraction.Play();
                }
                else if(goodRewardInteraction != null && Scene1Manager.instance.isRewardSelected == false)
                {
                    Scene1Manager.instance.isRewardSelected = true;
                    transform.DOMove( new Vector3( 0, 1.5f, -7.5f), 1.5f);
                    string[] billyYes = { "Pars pour ça." };
                    CustomSubtitleDisplay.instance.Display(billyYes, 3f);
                    goodRewardInteraction.Play();
                    StartCoroutine(EndWaiter());
                }
            }
        }
        
    }
}
