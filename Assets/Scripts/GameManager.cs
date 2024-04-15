using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject go = new GameObject("GameManager");
                    instance = go.AddComponent<GameManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }

    // Aquí puedes definir las variables que necesitas guardar
    private int puntuacion;

    void Awake()
    {
        // Cargar los datos guardados al iniciar la aplicación
        CargarDatos();
    }

    void OnApplicationQuit()
    {
        // Guardar los datos al cerrar la aplicación
        GuardarDatos();
    }

    public void GuardarDatos()
    {
        // Guardar todos los datos que necesitas
        PlayerPrefs.SetInt("puntuacion", puntuacion);
        PlayerPrefs.Save();
    }

    public void CargarDatos()
    {
        // Cargar todos los datos guardados
        puntuacion = PlayerPrefs.GetInt("puntuacion", 0);
    }
}
