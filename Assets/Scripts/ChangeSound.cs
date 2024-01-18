using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button soundButton;
    private bool isOn = true;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        soundOnImage = soundButton.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClicked()
    {
        if (isOn)
        {
            soundButton.image.sprite = soundOffImage;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            soundButton.image.sprite = soundOnImage;
            isOn = true;
            audioSource.mute = false;
        }
    }
}
