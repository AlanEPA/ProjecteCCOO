using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoom : MonoBehaviour
{
    public Image imageToScale;
    public float scaleFactor = 2f;

    void Start()
    {
        // Escalar la imagen al iniciar el juego
    }

    public void ScaleImage()
    {
        Debug.Log("Escaldado");
        // Verificar si la imagen está asignada
        if (imageToScale != null)
        {
            // Escalar la imagen usando el factor de escala definido
            imageToScale.rectTransform.localScale = new Vector3(scaleFactor, scaleFactor, 1f);
        }
        else
        {
            Debug.LogWarning("No se ha asignado ninguna imagen para escalar.");
        }
    }

    public void DescaleImage()
    {
        Debug.Log("Desescaldado");
        // Verificar si la imagen está asignada
        if (imageToScale != null)
        {
            // Desescalar la imagen estableciendo la escala a 1 en ambos ejes
            imageToScale.rectTransform.localScale = Vector3.one;
        }
        else
        {
            Debug.LogWarning("No se ha asignado ninguna imagen para desescalar.");
        }
    }
}
