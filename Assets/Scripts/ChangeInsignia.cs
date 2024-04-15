using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeInsignia : MonoBehaviour
{
    
    public GameObject insigniaBlocked;
    public GameObject insigniaUnblocked;
    private bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClicked()
    {
        if (isOn)
        {
            insigniaBlocked.SetActive(true);
            insigniaUnblocked.SetActive(false);
            isOn = false;
        }
        else
        {
            insigniaUnblocked.SetActive(true);
            insigniaBlocked.SetActive(false);  
            isOn = true;
        }
    }
}
