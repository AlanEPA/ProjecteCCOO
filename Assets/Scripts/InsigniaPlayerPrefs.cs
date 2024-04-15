using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsigniaPlayerPrefs : MonoBehaviour
{
    [SerializeField]
    private GameObject[] insigniasBloqueadas;

    [SerializeField]
    private GameObject[] insigniasDesbloqueadas;

    void Start()
    {
        CargarEstado();
    }

    public void GuardarEstado()
    {
        for (int i = 0; i < insigniasBloqueadas.Length; i++)
        {
            bool estado = insigniasBloqueadas[i].activeSelf;
            PlayerPrefs.SetInt("EstadoInsignia" + i, estado ? 1 : 0);
        }

        PlayerPrefs.Save();
    }

    public void CargarEstado()
    {
        for (int i = 0; i < insigniasBloqueadas.Length; i++)
        {
            int estadoGuardado = PlayerPrefs.GetInt("EstadoInsignia" + i, 1);
            insigniasBloqueadas[i].SetActive(estadoGuardado == 1);
            insigniasDesbloqueadas[i].SetActive(estadoGuardado != 1);
        }
    }
}



