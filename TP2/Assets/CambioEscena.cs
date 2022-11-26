using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{   
    public void CambiarNivel (int indice)
    {
        SceneManager.LoadScene(indice);
    }
}
