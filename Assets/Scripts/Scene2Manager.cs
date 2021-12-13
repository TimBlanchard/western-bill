using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Scene2Manager : MonoBehaviour
{
    public static Scene2Manager instance;

    private GameObject narratorContainer;

    private RectTransform RT;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        narratorContainer = GameObject.Find("NarratorContainer");
        RT = narratorContainer.GetComponent<RectTransform>();
        RT.DOAnchorPosX(600f, 0.6f, false);

        StartCoroutine(WistleStartDelay());
        StartCoroutine(SearchStartDelay());
        StartCoroutine(MozartStartDelay());

        StartCoroutine(BraveStartDelay());
        StartCoroutine(HorseStartDelay());
        StartCoroutine(SchoolStartDelay());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator BraveStartDelay()
    {
        yield return new WaitForSeconds(4);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator1 = { "Billy le brave, se dirigea vers sa monture, prêt à affronter cette nouvelle quête" };
        CustomNarratorDisplay.instance.Display(narrator1, 5f);
        StartCoroutine(Hide(5f));

    }
    IEnumerator WistleStartDelay()
    {
        yield return new WaitForSeconds(9);
        string[] subtitles = { "Billy : *Siffle*" };
        CustomSubtitleDisplay.instance.Display(subtitles, 3f);
        SoundManagerScript.PlayVoice ("scene2", "wistle");
    }
    
    IEnumerator SearchStartDelay()
    {
        yield return new WaitForSeconds(15);
        string[] subtitles = { "Billy : Bah il est où lui ?" };
        SoundManagerScript.PlayVoice ("scene2", "BillyShort");

        CustomSubtitleDisplay.instance.Display(subtitles, 3f);
    }

    IEnumerator SchoolStartDelay()
    {
        yield return new WaitForSeconds(20);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator2 = { "Avec son court passage à l'école nationale des arts de Monica (Texas)" };
        CustomNarratorDisplay.instance.Display(narrator2, 6f);
        StartCoroutine(Hide(6f));
    }
    IEnumerator HorseStartDelay()
    {
        yield return new WaitForSeconds(30);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator3 = { "Il eu le réflexe de sortir son instrument fétiche pour appeler son grandiose destrier." };
        CustomNarratorDisplay.instance.Display(narrator3, 8f);
        StartCoroutine(Hide(8f));
    }

    IEnumerator MozartStartDelay()
    {
        yield return new WaitForSeconds(36);
        string[] subtitles = { "Billy : Clair de Lune, Beethoven, comme à l'école !" };
        SoundManagerScript.PlayVoice ("scene2", "BillyContent");
        CustomSubtitleDisplay.instance.Display(subtitles, 4f);
    }



    public IEnumerator Hide(float wait) {
        yield return new WaitForSeconds(wait);
        RT.DOAnchorPosX(600f, 0.6f, false);
    }
}
