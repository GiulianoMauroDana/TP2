using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class BotonMute : MonoBehaviour
{
    Toggle botonMute;
           
    void Start()
    {
        botonMute = GetComponent<Toggle>();
        
        if (botonMute)
        {
            PlayerPrefs.SetFloat("estaMuteado", 0);
        }
        else
        {
            PlayerPrefs.SetFloat("estaMuteado", 1);
        }
                
    }    
}
