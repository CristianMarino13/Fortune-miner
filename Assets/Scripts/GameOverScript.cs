using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private PlayerManagerScript endVariable;
    void Start()
    {
        LoadScene3();
    }
    void LoadScene3()
    {
        if (endVariable.gameEnd == true)
        {
            SceneManager.LoadScene("FinalScene");
            LoadSceneOptions();
        }
    }
    void LoadSceneOptions()
    {
        
    }
}
