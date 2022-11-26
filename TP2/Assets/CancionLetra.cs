using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CancionLetra : MonoBehaviour
{
    public string[] letraCancion;
    public float[] tiempoInicial;
    public float[] tiempoFinal;
    public float velocidadLetra;
    private int indiceLetra;    
    public Text mostrarLetra;

    void Start()
    {        
        mostrarLetra.text = string.Empty;
        
    }

    void Update()
    {
        for (indiceLetra = 0; indiceLetra < letraCancion[indiceLetra].Length; indiceLetra++)
        {
            new WaitForSeconds(velocidadLetra);
            mostrarLetra.text = letraCancion[indiceLetra];
            mostrarLetra.text = string.Empty;
        }
    }    
}
