using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip DO, RE, MI, FA, SOL, LA, TI, MUSIC_CHECK;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {

        DO = Resources.Load<AudioClip>("DO");
        RE = Resources.Load<AudioClip>("RE");
        MI = Resources.Load<AudioClip>("MI");
        FA = Resources.Load<AudioClip>("FA");
        SOL = Resources.Load<AudioClip>("SOL");
        LA = Resources.Load<AudioClip>("LA");
        TI = Resources.Load<AudioClip>("TI");
        MUSIC_CHECK = Resources.Load<AudioClip>("MUSIC_CHECK");
        audioSrc = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {

        
    }

    public static void PlaySound(string clip)

    {
        switch (clip)
        {
            case "DO":
                audioSrc.PlayOneShot(DO);
                break;
            case "RE":
                audioSrc.PlayOneShot(RE);
                break;
            case "MI":
                audioSrc.PlayOneShot(MI);
                break;
            case "FA":
                audioSrc.PlayOneShot(FA);
                break;
            case "SOL":
                audioSrc.PlayOneShot(SOL);
                break;
            case "LA":
                audioSrc.PlayOneShot(LA);
                break;
            case "TI":
                audioSrc.PlayOneShot(TI);
                break;
            case "MUSIC_CHECK":
                audioSrc.PlayOneShot(MUSIC_CHECK);
                break;



        }
        


    }
}
