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
        // Si el slider est� activo, desact�valo
        if (sliderActive)
        {
            sliderObject.SetActive(false);
            sliderActive = false;
        }
        else
        {
            // Si el slider est� desactivado, act�valo
            sliderObject.SetActive(true);
            sliderActive = true;
        }
    }
}