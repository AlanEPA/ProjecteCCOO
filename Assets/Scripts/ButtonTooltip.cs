using UnityEngine;
using UnityEngine.UI;

public class ButtonTooltip : MonoBehaviour
{
    public GameObject imagen; // Referencia al GameObject que contiene la RawImage

    // M�todo que se llama cuando se pulsa el bot�n
    public void ToggleImageVisibility()
    {
        // Obtiene el estado actual de activaci�n del GameObject imagen y lo invierte
        bool isActive = imagen.activeSelf;
        imagen.SetActive(!isActive);
    }
}