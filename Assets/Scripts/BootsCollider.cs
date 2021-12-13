using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootsCollider : MonoBehaviour
{
    public bool triggered = false;

    void OnTriggerEnter(Collider other)
    {
        if(!triggered) {
            triggered = true;
            StartCoroutine(MochesStartDelay());
        }
    }

    IEnumerator MochesStartDelay()
    {
        yield return new WaitForSeconds(0);
        string[] subtitles = { "Billy : Oh merde elles sont si moche ces b..." };
        SoundManagerScript.PlayVoice ("scene2", "BillyEtonne");

        CustomSubtitleDisplay.instance.Display(subtitles, 4f);
        StartCoroutine(Chasseur1StartDelay());
    }

    IEnumerator Chasseur1StartDelay()
    {
        yield return new WaitForSeconds(4);
        string[] subtitles = { "Chasseur de primes 1: C'est quand même sacrément stupide de pas avoir accroché proprement les bottes à ton sac Joe !" };
        SoundManagerScript.PlayVoice ("scene2", "CUL");

        CustomSubtitleDisplay.instance.Display(subtitles, 3f);
        StartCoroutine(Chasseur2StartDelay());
    }
    IEnumerator Chasseur2StartDelay()
    {
        yield return new WaitForSeconds(3);
        string[] subtitles = { "Chasseur de primes 2: J'vais te mettre les miennes dans le cul si t'arrêtes pas de te plaindre ! Elles sont pas loin ces bottes je te dis, je les sens d'ici" };
        CustomSubtitleDisplay.instance.Display(subtitles, 7f);
        StartCoroutine(OutroStartDelay());
    }

    IEnumerator OutroStartDelay()
    {
        yield return new WaitForSeconds(8);
        MainController.Instance.ChangeScene(5);

    }
}
