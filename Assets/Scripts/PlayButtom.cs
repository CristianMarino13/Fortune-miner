using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButtom : MonoBehaviour
{
    public string oneScene;
    public AudioSource audioDefault;
    public void LoadGame()
    {
        audioDefault.Stop();
        SceneManager.LoadScene(oneScene);
    }

}
