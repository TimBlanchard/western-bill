using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip villager, mario, akuaku, horse, harmo1, harmo2, harmo3, harmo4, harmo5, harmo6, S1Sherif1, S1Sherif2, S1Cowboy, S2Cheval, S2Ciseaux, S2Maman, S2Octogone, S2Rat, S2Recadre, S2Tg, S3Yahoo1, S3Yahoo2, S3Yahoo3, BillyShort, BillyContent, BillyEtonne, BillyLong, CUL, wistle;
    static AudioSource audioSrc, harmonicaSrc, voiceSrc;

    // Start is called before the first frame update
    void Start()
    {

        villager = Resources.Load<AudioClip> ("villager");
        mario = Resources.Load<AudioClip> ("mario");
        akuaku = Resources.Load<AudioClip> ("akuaku");

        harmo1 = Resources.Load<AudioClip> ("D");
        harmo2 = Resources.Load<AudioClip> ("F");
        harmo3 = Resources.Load<AudioClip> ("G");
        harmo4 = Resources.Load<AudioClip> ("H");
        harmo5 = Resources.Load<AudioClip> ("R");
        harmo6 = Resources.Load<AudioClip> ("Y");


        S1Sherif1 = Resources.Load<AudioClip> ("CONTENT");
        S1Sherif2 = Resources.Load<AudioClip> ("BOTTES");
        S1Cowboy = Resources.Load<AudioClip> ("COUSIN");

        S2Cheval = Resources.Load<AudioClip> ("CHEVAL");
        S2Ciseaux = Resources.Load<AudioClip> ("CISEAUX");
        S2Maman = Resources.Load<AudioClip> ("MAMAN");
        S2Octogone = Resources.Load<AudioClip> ("OCTOGONE");
        S2Rat = Resources.Load<AudioClip> ("RAT");
        S2Recadre = Resources.Load<AudioClip> ("RECADRE");
        S2Tg = Resources.Load<AudioClip> ("TG");
        
        S3Yahoo1 = Resources.Load<AudioClip> ("YIHAA");
        S3Yahoo2 = Resources.Load<AudioClip> ("YIHAA2");
        S3Yahoo3 = Resources.Load<AudioClip> ("YIHAA3");

        BillyShort = Resources.Load<AudioClip> ("BillyShort");
        BillyContent = Resources.Load<AudioClip> ("BillyContent");
        BillyLong = Resources.Load<AudioClip> ("BillyLong");
        BillyEtonne = Resources.Load<AudioClip> ("BillyEtonne");

        CUL = Resources.Load<AudioClip> ("CUL");

        horse = Resources.Load<AudioClip> ("horse");
        wistle = Resources.Load<AudioClip> ("wistle");

        audioSrc = GetComponent<AudioSource> ();

        harmonicaSrc = GetComponent<AudioSource> ();

        voiceSrc = GetComponent<AudioSource> ();

        // PlayHarmonicaNote();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound (string clip)
    {
        audioSrc.PlayOneShot(villager);
    }

    public static void PlaySoundAndDisplayLine (string clip) 
    {
        switch (clip) {
            // SubtitleManager.displayLine(line)
        }
    }

    public static void PlayHarmonicaNote ()
    {
        Debug.Log("Play in sondmanager");

        int rand = Random.Range(0, 7);

        switch (rand) {
            case 0:
            harmonicaSrc.PlayOneShot(harmo1);
            break;
            case 1:
            harmonicaSrc.PlayOneShot(harmo2);
            break;
            case 2:
            harmonicaSrc.PlayOneShot(harmo3);
            break;
            case 3:
            harmonicaSrc.PlayOneShot(harmo4);
            break;
            case 4:
            harmonicaSrc.PlayOneShot(harmo5);
            break;
            case 5:
            harmonicaSrc.PlayOneShot(harmo6);
            break;
        }
    }

    public static void PlayVoice (string scene, string voice) {
        if(scene == "scene2" && voice == "cheval") {
            voiceSrc.PlayOneShot(S2Cheval);
            // Subtitles.instance.Next();
        } else if(scene == "scene2" && voice == "ciseaux") {
            voiceSrc.PlayOneShot(S2Ciseaux);
        } else if(scene == "scene2" && voice == "maman") {
            voiceSrc.PlayOneShot(S2Maman);
        } else if(scene == "scene2" && voice == "octogone") {
            voiceSrc.PlayOneShot(S2Octogone);
        } else if(scene == "scene2" && voice == "tg") {
            voiceSrc.PlayOneShot(S2Tg);
        } else if(scene == "scene2" && voice == "recadre") {
            voiceSrc.PlayOneShot(S2Recadre);
        } else if(scene == "scene2" && voice == "horse") {
            voiceSrc.PlayOneShot(horse);
        } else if(scene == "scene2" && voice == "wistle") {
            voiceSrc.PlayOneShot(wistle);
        } else if(scene == "scene2" && voice == "recadre") {
            voiceSrc.PlayOneShot(S2Recadre);
        } else if(scene == "scene2" && voice == "rat") {
            voiceSrc.PlayOneShot(S2Rat);
        } else if(scene == "scene2" && voice == "BillyLong") {
            audioSrc.PlayOneShot(BillyLong);
        } else if(scene == "scene2" && voice == "BillyContent") {
            audioSrc.PlayOneShot(BillyContent);
        } else if(scene == "scene2" && voice == "BillyShort") {
            audioSrc.PlayOneShot(BillyShort);
        } else if(scene == "scene2" && voice == "BillyEtonne") {
            audioSrc.PlayOneShot(BillyEtonne);
        } else if(scene == "scene2" && voice == "CUL") {
            audioSrc.PlayOneShot(CUL);
        }

        if(scene == "3" && voice == "YIHAA") {
            voiceSrc.PlayOneShot(S3Yahoo1);
        } else if (scene == "3" && voice == "YIHAA2") {
            voiceSrc.PlayOneShot(S3Yahoo2);
        } else if (scene == "3" && voice == "YIHAA3") {
            voiceSrc.PlayOneShot(S3Yahoo2);
        }

        if(scene == "scene4") {
            voiceSrc.PlayOneShot(CUL);
        }

    }
}
