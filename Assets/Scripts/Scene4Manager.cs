using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Scene4Manager : MonoBehaviour
{
    public static Scene4Manager instance;

    private GameObject narratorContainer;

    private RectTransform RT;
    public Animator animator;

    private bool canPlay = false, hasPlayed = false;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        // animator = gameObject.GetComponent<Animator>();


        narratorContainer = GameObject.Find("NarratorContainer");
        RT = narratorContainer.GetComponent<RectTransform>();
        RT.DOAnchorPosX(600f, 0.6f, false);

        StartCoroutine(AfterStartDelay());
        StartCoroutine(After2StartDelay());
        StartCoroutine(After3StartDelay());


        StartCoroutine(HorseRunStartDelay());
        StartCoroutine(BackStartDelay());
        StartCoroutine(MontureStartDelay());
        StartCoroutine(SongStartDelay());
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canPlay) {
            if(!hasPlayed) {
                if(Input.anyKey) {
                    hasPlayed = true;
                    StartCoroutine(DiscoverStartDelay());
                }
            }
        }
    }
    IEnumerator AfterStartDelay()
    {
        yield return new WaitForSeconds(4);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator1 = { "Après une course folle, notre héros arriva aux abords d'étranges ruines.",  };
        CustomNarratorDisplay.instance.Display(narrator1, 6f);
        StartCoroutine(Hide(6f));
    }
    IEnumerator After2StartDelay()
    {
        yield return new WaitForSeconds(13);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator2 = { "Le chemin pour retrouver les bottes du maire n'étant pourtant pas indiqué sur la prime"};
        CustomNarratorDisplay.instance.Display(narrator2, 5f);
        StartCoroutine(Hide(5f));
    }
    IEnumerator After3StartDelay()
    {
        yield return new WaitForSeconds(21);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator3 = { "Billy avait eu une intuition... Ou beaucoup de chance" };
        CustomNarratorDisplay.instance.Display(narrator3, 5f);
        StartCoroutine(Hide(5f));
    }

    IEnumerator HorseRunStartDelay()
    {
        yield return new WaitForSeconds(24);
        //animator.SetTrigger("Run");
        animator.SetBool("isRunning", true);
    }



    IEnumerator BackStartDelay()
    {
        yield return new WaitForSeconds(24);
        string[] subtitles = { "Billy : Eh mais revient kiki !" };
        CustomSubtitleDisplay.instance.Display(subtitles, 3f);
        SoundManagerScript.PlayVoice ("scene2", "BillyEtonne");
    }

    IEnumerator MontureStartDelay()
    {
        yield return new WaitForSeconds(28);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator4 = { "Sa monture lui donnait du fil à retordre. Une fois n'est pas coutume, il tenta de l'appeler." };
        CustomNarratorDisplay.instance.Display(narrator4, 6f);
        StartCoroutine(Hide(6f));
    }
    
    
    IEnumerator SongStartDelay()
    {
        yield return new WaitForSeconds(33);
        string[] subtitles = { "Billy : Je crois que si je fais Fa Sol Do# ça fait un truc" };
        SoundManagerScript.PlayVoice ("scene2", "BillyContent");

        CustomSubtitleDisplay.instance.Display(subtitles, 5f);
        canPlay = true;
    }
    
    IEnumerator DiscoverStartDelay()
    {
        yield return new WaitForSeconds(4);
        string[] subtitles = { "Billy : ... Mais... C'est quoi ce bordel ?" };
        SoundManagerScript.PlayVoice ("scene2", "BillyEtonne");

        CustomSubtitleDisplay.instance.Display(subtitles, 5f);

        StartCoroutine(PasStartDelay());
    }
    IEnumerator PasStartDelay()
    {
        yield return new WaitForSeconds(4);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator4 = { "Mais ? Cet harmonica qu'un vieux shaman lui avait donnée était donc bien magique ?" };
        CustomNarratorDisplay.instance.Display(narrator4, 6f);
        StartCoroutine(Hide(6f));
        
        StartCoroutine(MagiqueStartDelay());
    }
    IEnumerator MagiqueStartDelay()
    {
        yield return new WaitForSeconds(4);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator4 = { "Moi même je ne m'y attendais pas, je vais boire un verre d'eau." };
        CustomNarratorDisplay.instance.Display(narrator4, 6f);
        StartCoroutine(Hide(6f));
    }

    public IEnumerator Hide(float wait) {
        yield return new WaitForSeconds(wait);
        RT.DOAnchorPosX(600f, 0.6f, false);
    }
}
