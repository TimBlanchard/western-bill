using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip villager, mario, akuaku, harmo1, harmo2, harmo3, harmo4, harmo5, harmo6;
    static AudioSource audioSrc, harmonicaSrc;

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

        audioSrc = GetComponent<AudioSource> ();

        harmonicaSrc = GetComponent<AudioSource> ();

        PlayHarmonicaNote();
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
            case "villager":
            audioSrc.PlayOneShot(villager);
            break;
            case "mario":
            audioSrc.PlayOneShot(mario);
            break;
            case "akuaku":
            audioSrc.PlayOneShot(akuaku);
            break;
            // SubtitleManager.displayLine(line)
        }
    }

    public static void PlayHarmonicaNote ()
    {
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
}
