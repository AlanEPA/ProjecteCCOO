using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAudioToScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        // Asegúrate de que este objeto no se destruya al cargar una nueva escena
        DontDestroyOnLoad(this.gameObject);
    }
}
