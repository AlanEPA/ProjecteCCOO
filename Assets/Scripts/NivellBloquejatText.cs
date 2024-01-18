using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivellBloquejatText : MonoBehaviour
{

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
        canvasSiguiente.SetActive(true);
    }

}