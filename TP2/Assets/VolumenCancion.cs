using UnityEngine;


public class VolumenCancion : MonoBehaviour
{
    public AudioSource volumenAudio;
   
    void Start()
    {
        volumenAudio.volume = PlayerPrefs.GetFloat("NivelAudio");
        volumenAudio.mute = PlayerPrefs.GetInt("estaMuteado") == 0;
    }
}
