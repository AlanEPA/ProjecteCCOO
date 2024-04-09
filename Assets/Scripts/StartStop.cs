using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Sprites;

public class StartStop : MonoBehaviour
{
    private VideoPlayer player;
    public Button button;
    public Sprite startSprite;
    public Sprite stopSprite;

    void Start()
    {
        player = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeStartStop()
    {
        if (player.isPlaying == false)
        {
            player.Play();
            button.image.sprite = stopSprite;
        }
        else
        {
            player.Pause();
            button.image.sprite = startSprite;
        }

    }
}
