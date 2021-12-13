using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Scene3Manager : MonoBehaviour
{
    public static Scene3Manager instance;

    private GameObject narratorContainer;

    private RectTransform RT;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        narratorContainer = GameObject.Find("NarratorContainer");
        RT = narratorContainer.GetComponent<RectTransform>();
        RT.DOAnchorPosX(600f, 0.6f, false);

        StartCoroutine(MissionStartDelay());
        StartCoroutine(Mission2StartDelay());
        StartCoroutine(Mission3StartDelay());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MissionStartDelay()
    {
        yield return new WaitForSeconds(4);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator1 = { "Cette mission était cruciale, la ville commençaient à manquer d'ordre depuis que le Maire s'était cloitré chez lui," };
        CustomNarratorDisplay.instance.Display(narrator1, 5f);
        StartCoroutine(Hide(5f));

    }
    IEnumerator Mission2StartDelay()
    {
        yield return new WaitForSeconds(12);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator2 = { "refusant de sortir sans bottes et d'exhiber ses pieds à la population de Bodie" };
        CustomNarratorDisplay.instance.Display(narrator2, 4f);
        StartCoroutine(Hide(4f));

    }
    IEnumerator Mission3StartDelay()
    {
        yield return new WaitForSeconds(20);
        RT.DOAnchorPosX(-20f, 0.6f, false);
        string[] narrator3 = { "C'était enfin l'heure pour lui de briller, et de prouver à sa maman qu'il avait fait le bon choix en devenant Inspecteur" };
        CustomNarratorDisplay.instance.Display(narrator3, 5f);
        StartCoroutine(Hide(5f));

    }

    public IEnumerator Hide(float wait) {
        yield return new WaitForSeconds(wait);
        RT.DOAnchorPosX(600f, 0.6f, false);
    }
}
