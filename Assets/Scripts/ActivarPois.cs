using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ActivarPois : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject objetoActivar;
    public GameObject objetoDesActivar;
    public GameObject objetoSiguienteActivar;
    public GameObject objetoSiguienteDesActivar;
    void Start()
    {
        // Suscribirse al evento loopPointReached del VideoPlayer
        videoPlayer.loopPointReached += VideoTerminado;
    }

    void VideoTerminado(VideoPlayer vp)
    {
        objetoDesActivar.SetActive(false);
        objetoActivar.SetActive(true);
        objetoSiguienteActivar.SetActive(true);
        objetoSiguienteDesActivar.SetActive(false);
        objetoSiguienteDesActivar.SetActive(false);
    }

    void OnDestroy()
    {
        // Asegurarse de eliminar el listener del evento cuando el objeto se destruye
        videoPlayer.loopPointReached -= VideoTerminado;
    }
}
