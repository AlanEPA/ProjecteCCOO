using UnityEngine;
using UnityEngine.UI;

public class ButtonTooltip : MonoBehaviour
{
    public GameObject imagen; // Referencia al GameObject que contiene la RawImage

    // Método que se llama cuando se pulsa el botón
    public void ToggleImageVisibility()
    {
        // Obtiene el estado actual de activación del GameObject imagen y lo invierte
        bool isActive = imagen.activeSelf;
        imagen.SetActive(!isActive);
    }
}