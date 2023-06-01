using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButtom : MonoBehaviour
{
    public string oneScene;
    public void LoadGame()
    {
        SceneManager.LoadScene(oneScene);
    }

}
