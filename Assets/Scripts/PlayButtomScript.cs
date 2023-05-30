using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButtomScript : MonoBehaviour
{
    public string sceneName;
    void Start()
    {
        Invoke ( "LoadScene",3.0f);
    }
    void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
