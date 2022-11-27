using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class CancionLetra : MonoBehaviour
{
    
    private int indiceTexto;
    public Text mostrarTexto;
    public float[] velocidadLetra;
    public string[] cancionLetra;
    
    void Start()
    {
        mostrarTexto.text = string.Empty;
        StartCoroutine(MostrarLetra());
    }
    
    IEnumerator MostrarLetra()
    {
        //1
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //2
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //3
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //4
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //5
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //6
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //7
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //8
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //9
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //10
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //11
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //12
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //13
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //14
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //15
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //16
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //17
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //18
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //19
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //20
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //21
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //22
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //23
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;
        //24
        yield return new WaitForSeconds(velocidadLetra[indiceTexto] - Time.time);
        mostrarTexto.text = cancionLetra[indiceTexto];
        indiceTexto++;

    }
}
