using UnityEngine;
using UnityEngine.UI;

public class ControlSlider : MonoBehaviour
{
    [SerializeField] Slider controlVolumen;

    void Start()
    {        
        controlVolumen.value = PlayerPrefs.GetFloat("NivelAudio");
    }

    public void GuardarSlider()
    {
        PlayerPrefs.SetFloat("NivelAudio", controlVolumen.value);
    }
}
