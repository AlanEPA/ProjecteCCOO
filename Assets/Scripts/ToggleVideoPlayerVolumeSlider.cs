using UnityEngine;
using UnityEngine.UI;

public class ToggleVideoPlayerVolumeSlider : MonoBehaviour
{
    public GameObject sliderObject; // Referencia al GameObject que contiene el slider

    private bool sliderActive = false; // Estado actual del slider

    private void Start()
    {
        // Asegurarse de que el GameObject del slider se haya asignado en el Inspector
        if (sliderObject == null)
        {
            Debug.LogError("Slider object reference not set in ToggleSlider script!");
        }
    }

    public void ToggleSliderActivation()
    {
        // Si el slider está activo, desactívalo
        if (sliderActive)
        {
            sliderObject.SetActive(false);
            sliderActive = false;
        }
        else
        {
            // Si el slider está desactivado, actívalo
            sliderObject.SetActive(true);
            sliderActive = true;
        }
    }
}