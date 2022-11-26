using UnityEngine;

public class Volumen : MonoBehaviour
{
    private AudioSource musicaVolumen;

    private void Start()
    {
       musicaVolumen.volume = PlayerPrefs.GetFloat("VolumenMusica");
       
       musicaVolumen.mute = PlayerPrefs.GetInt("estaMuteado") == 1;
               
    }       
}
