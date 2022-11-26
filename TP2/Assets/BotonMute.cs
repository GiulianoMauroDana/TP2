using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class BotonMute : MonoBehaviour
{
    Toggle botonMute;
           
    void Start()
    {
        botonMute = GetComponent<Toggle>();
        
        if (botonMute.isOn)
        {
            PlayerPrefs.SetFloat("estaMuteado", 0);
        }
        else
        {
            PlayerPrefs.SetFloat("estaMuteado", 1);
        }
        /*
        if (PlayerPrefs.GetFloat("estaMuteado")==0)
        {
            botonMute.isOn;
        }
        */
    }    
}
