using UnityEngine;
using UnityEngine.UI;

public class ControlVolumen : MonoBehaviour
{   
    [SerializeField] Slider volumenSlider;
    //private AudioSource valorVolumen;

    public void Start()
    {
        if (!PlayerPrefs.HasKey("VolumenMusica"))
        {            
            CargarVolumen();
        }        
    }

    public void CambiarVolumen()
    {
        /*
        valorVolumen.volume = volumenSlider.value;
        GuadarVolumen();
        */
        
        AudioListener.volume = volumenSlider.value;
        GuadarVolumen();
        

    }

    public void CargarVolumen()
    {
        volumenSlider.value = PlayerPrefs.GetFloat("VolumenMusica");
    }

    public void GuadarVolumen()
    {
        PlayerPrefs.SetFloat("VolumenMusica", volumenSlider.value);
    }
}
