using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class ManagerScene : MonoBehaviour
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
    public void ResetButton()
    {
        SceneManager.LoadScene(0);
    }
    public void CambiarCanvas()
    {
        canvasActual.SetActive(false);
        canvasSiguiente.SetActive(true);
    }
    public void ActivarCanvas()
    {
        canvasSiguiente.SetActive(true);
    }
}
