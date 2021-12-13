using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HarmonicaDisplay : MonoBehaviour
{

    public Harmonica harmonica;
    public int scene;

    private int count;

    private bool canPlay = true;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (canPlay)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.H) || Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.N))
            {
                if (scene == 2)
                {
                    Debug.Log(scene);

                    count++;
                    if (count % 10 == 0)
                    {
                        canPlay = false;
                        StartCoroutine(ChangeCanPlay());

                        switch (count)
                        {
                            case 10:
                                SoundManagerScript.PlayVoice ("scene2", "horse");
                                string[] horseSubtitle = { "Cheval : *hennie*" };
                                CustomSubtitleDisplay.instance.Display(horseSubtitle, 3f);
                            break;
                            case 20:
                                SoundManagerScript.PlayVoice ("scene2", "cheval");
                                string[] chevalSubtitle = { "Villageois 1: Billy si tu continues j'te crève les roues de ton cheval !" };
                                CustomSubtitleDisplay.instance.Display(chevalSubtitle, 5f);
                            break;
                            case 30:
                                SoundManagerScript.PlayVoice ("scene2", "ciseaux");
                                string[] ciseauxSubtitle = { "Villageois 2: Où est ce que j'ai foutu mes ciseaux ? je regrette d'avoir des oreilles" };
                                CustomSubtitleDisplay.instance.Display(ciseauxSubtitle, 5f);
                            break;
                            case 40:
                                SoundManagerScript.PlayVoice ("scene2", "horse");
                                string[] horseSubtitle2 = { "Cheval : *hennie*" };
                                CustomSubtitleDisplay.instance.Display(horseSubtitle2, 3f);
                            break;
                            case 50:
                                SoundManagerScript.PlayVoice ("scene2", "maman");
                                string[] mamanSubtitle = { "Villageois 3: Maman, pourquoi Papi il convulse ?" };
                                CustomSubtitleDisplay.instance.Display(mamanSubtitle, 4f);
                            break;
                            case 60:
                                SoundManagerScript.PlayVoice ("scene2", "octogone");
                                string[] octogoneSubtitle = { "Villageois 4: J'suis à deux doigts d'inventer l'octogone" };
                                CustomSubtitleDisplay.instance.Display(octogoneSubtitle, 4f);
                            break;
                            case 70:
                                SoundManagerScript.PlayVoice ("scene2", "horse");
                                string[] horseSubtitle3 = { "Cheval : *hennie*" };
                                CustomSubtitleDisplay.instance.Display(horseSubtitle3, 3f);
                            break;
                            case 80:
                                SoundManagerScript.PlayVoice ("scene2", "tg");
                                string[] tgSubtitle = { "Villageois 5: Ah ta gu****!" };
                                CustomSubtitleDisplay.instance.Display(tgSubtitle, 3f);
                            break;
                            case 90:
                                SoundManagerScript.PlayVoice ("scene2", "recadre");
                                string[] recadreSubtitle = { "Villageois 6: Ah si seulement le Maire avait pas perdu ses bottes il pourrait sortir de chez lui, et recadrer un peu Billy." };
                                CustomSubtitleDisplay.instance.Display(recadreSubtitle, 7f);
                            break;
                        }
                    }
                }
                harmonica.PlayNote();
            }
        }
    }


    public IEnumerator ChangeCanPlay()
    {
        yield return new WaitForSeconds(5);
        canPlay = true;
    }
}
