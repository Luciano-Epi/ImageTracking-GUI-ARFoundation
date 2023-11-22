using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bordes : MonoBehaviour
{
    public float grosorMarco = 0.1f; // Grosor del marco

    void Start()
    {
        CrearMarcos();
    }

    void CrearMarcos()
    {
        Camera cam = Camera.main;

        if (cam == null)
        {
            Debug.LogError("No se encontró una cámara principal en la escena.");
            return;
        }

        // Crear marco superior
        CrearMarco(new Vector3(0, 1, 0.5f), new Vector3(2, grosorMarco, 1));

        // Crear marco inferior
        CrearMarco(new Vector3(0, 0, 0.5f), new Vector3(2, grosorMarco, 1));

        // Crear marco izquierdo
        CrearMarco(new Vector3(-1, 0.5f, 0.5f), new Vector3(grosorMarco, 2, 1));

        // Crear marco derecho
        CrearMarco(new Vector3(1, 0.5f, 0.5f), new Vector3(grosorMarco, 2, 1));
    }

    void CrearMarco(Vector3 posicion, Vector3 escala)
    {
        GameObject marco = GameObject.CreatePrimitive(PrimitiveType.Cube);
        marco.transform.position = posicion;
        marco.transform.localScale = escala;
        marco.GetComponent<Renderer>().material.color = Color.black;
        marco.GetComponent<BoxCollider>().enabled = false; // Desactivar el colisionador para que no interfiera con otros objetos
    }
}

