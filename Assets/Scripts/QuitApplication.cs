using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public void Sortir()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}