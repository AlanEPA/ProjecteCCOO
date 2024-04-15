using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerVolumeSlider : MonoBehaviour
{
    public Slider slider;
    public VideoPlayer videoPlayer;

    private void Start()
    {
        // Asegurarse de que el slider esté configurado correctamente
        if (slider == null)
        {
            Debug.LogError("Slider reference not set in VolumeSlider script!");
            return;
        }

        // Asegurarse de que el video player esté configurado correctamente
        if (videoPlayer == null)
        {
            Debug.LogError("VideoPlayer reference not set in VolumeSlider script!");
            return;
        }

        // Configurar el listener del slider para que actualice el volumen del video player
        slider.onValueChanged.AddListener(delegate { OnSliderValueChanged(); });
    }

    private void OnSliderValueChanged()
    {
        // Obtener el valor actual del slider y establecerlo como el volumen del video player
        if (videoPlayer != null)
        {
            videoPlayer.SetDirectAudioVolume(0, slider.value);
        }
    }
}