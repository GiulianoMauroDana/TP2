using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class BotonMute : MonoBehaviour
{
    Toggle botonMute;
           
    void Start()
    {
        if (botonMute.isOn)
        {
            PlayerPrefs.SetFloat("estaMuteado", 0);
        }
        else
        {
            PlayerPrefs.SetFloat("estaMuteado", 1);
        }
    }    
}
