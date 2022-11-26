using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class ControlAudio : MonoBehaviour
{
    [SerializeField] Slider controlVolumen;
    Toggle botonMute;

    void Start()
    {
        //PlayerPrefs.SetFloat("NivelAudio", controlVolumen.value);
        botonMute = GetComponent<Toggle>();
        //PlayerPrefs.SetInt("estaMuteado", 1);
        botonMute.isOn = PlayerPrefs.GetInt("estaMuteado")==1;
    }

    void Update()
    {
        
    }    

    public void CambiarToggle()
    {
        if (botonMute.isOn)
        {
            PlayerPrefs.SetInt("estaMuteado", 1);
        }
        else
        {
            PlayerPrefs.SetInt("estaMuteado", 0);
        }

        botonMute.isOn = PlayerPrefs.GetInt("estaMuteado") == 1;
    }
}
