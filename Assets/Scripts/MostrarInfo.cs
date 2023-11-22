using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarInfo : MonoBehaviour
{
    public GameObject textoAMostrar;
    private float duracionDelTexto = 4f;
    public void MostrarTextoPorTiempo()
    {
        StartCoroutine(MostrarTextoTemporal());
    }

    IEnumerator MostrarTextoTemporal()
    {
        // Activar el objeto de texto
        textoAMostrar.gameObject.SetActive(true);

        // Esperar por la duración especificada
        yield return new WaitForSeconds(duracionDelTexto);

        // Desactivar el objeto de texto después de la espera
        textoAMostrar.gameObject.SetActive(false);
    }
}
