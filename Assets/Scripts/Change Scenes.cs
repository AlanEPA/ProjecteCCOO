using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeSceneEscenaBase()
    {
        Debug.Log("Click");
        SceneManager.LoadScene(0);
    }
    public void ChangeSceneLvl1()
    {
        SceneManager.LoadScene("lvl1");
    }
    public void ChangeSceneLvl2()
    {
        SceneManager.LoadScene("lvl2");
    }
    public void ChangeSceneLvl3()
    {
        SceneManager.LoadScene("lvl3");
    }
    public void ChangeSceneLvl4()
    {
        SceneManager.LoadScene("lvl4");
    }
    public void ChangeSceneLvl5()
    {
        SceneManager.LoadScene("lvl5");

    }
    public void ChangeSceneLvl6()
    {
        SceneManager.LoadScene("lvl6");
    }
    public void ChangeSceneLvl7()
    {
        SceneManager.LoadScene("lvl7");
    }

    public void ChangeSceneInsigniaPoi1()
    {
       SceneManager.LoadSceneAsync("Insignias");

    }
}
