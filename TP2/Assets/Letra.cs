using System.Collections;
using UnityEngine;
using TMPro;


public class Letra : MonoBehaviour
{
    private TextMeshProUGUI letraCancion;
    public string[] lineasCancion;
    public float velocidadTexto;
    private bool siCominezoCancion;
    int indiceTexto;
    public float[] inicioLinea;
    public float[] finLinea;
        
    void Start()
    {
        letraCancion.text = string.Empty;
        ComienzotCancion();        
    }
        
    void Update()
    {
       
        if (!siCominezoCancion)
        {
            ComienzotCancion();
        }
        else 
        
        if(letraCancion.text == lineasCancion[indiceTexto])
        {
            CambioLinea();
        }

    }

    public void ComienzotCancion()
    {
        siCominezoCancion = true;
        indiceTexto = 0;
        StartCoroutine(EscribirTexto());
    }

    IEnumerator EscribirTexto ()
    {        
        foreach (char texto in lineasCancion[indiceTexto].ToCharArray())
        {
            letraCancion.text += texto;            
            yield return new WaitForSeconds((finLinea[indiceTexto] - inicioLinea[indiceTexto]) / (lineasCancion[indiceTexto].Length + velocidadTexto));
            CambioLinea();
        }         
    }

    public void CambioLinea()
    {
        if (indiceTexto < lineasCancion.Length-1)
        {
            indiceTexto++;
            letraCancion.text = string.Empty;
            StartCoroutine(EscribirTexto());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }    
}
