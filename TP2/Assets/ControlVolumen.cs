using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ControlVolumen : MonoBehaviour
{   
    [SerializeField] Slider volumenSlider;

    public void Start()
    {
        if (!PlayerPrefs.HasKey("VolumenMusica"))
        {            
            CargarVolumen();
        }
        else
        {
            CargarVolumen();
        }
    }

    public void CambiarVolumen()
    {
        AudioListener.volume = Mathf.Log10(volumenSlider.value);
        GuadarVolumen();
    }

    public void CargarVolumen()
    {
        volumenSlider.value = PlayerPrefs.GetFloat("VolumenMusica");
    }

    public void GuadarVolumen()
    {
        PlayerPrefs.SetFloat("VolumenMusica", Mathf.Log10(volumenSlider.value));
    }
}
