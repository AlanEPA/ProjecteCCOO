using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TipDisableScript : MonoBehaviour
{
   public GameObject canvasActual;
   public GameObject canvasSiguiente;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambiarCanvas()
    {
        canvasActual.SetActive(false);
        canvasSiguiente.SetActive(true);
    }
}