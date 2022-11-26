using UnityEngine;
using UnityEngine.UI;

public class ControlSlider : MonoBehaviour
{
    [SerializeField] Slider controlVolumen;

    void Start()
    {
        //PlayerPrefs.SetFloat("NivelAudio", 0);
        controlVolumen.value = PlayerPrefs.GetFloat("NivelAudio");
    }

    void Update()
    {
        
    }

    public void CambiarSlider()
    {
        controlVolumen.value = PlayerPrefs.GetFloat("NivelAudio");
    }

    public void GuardarSlider()
    {
        PlayerPrefs.SetFloat("NivelAudio", controlVolumen.value);
    }
}
