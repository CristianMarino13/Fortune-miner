using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButtomScript : MonoBehaviour
{
    
    void Start()
    {
        Invoke ( "LoadScene",3.0f);
    }
    void LoadScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
