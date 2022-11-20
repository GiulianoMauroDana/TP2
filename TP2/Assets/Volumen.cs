using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volumen : MonoBehaviour
{
    public AudioSource musicaVolumen;

    private void Start()
    {
       musicaVolumen.volume = PlayerPrefs.GetFloat("VolumenMusica");
        if (musicaVolumen.mute)
        {
            PlayerPrefs.GetFloat("estaMuteado",1);
        }
        else
        {
            PlayerPrefs.GetFloat("estaMuteado", 0);
        }
    }       
}
