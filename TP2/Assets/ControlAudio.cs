using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class ControlAudio : MonoBehaviour
{
    
    Toggle botonMute;

    void Start()
    {
       
        botonMute = GetComponent<Toggle>();        
        botonMute.isOn = PlayerPrefs.GetInt("estaMuteado",0)==1;
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
    }    
}
