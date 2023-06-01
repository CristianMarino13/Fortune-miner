using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private PlayerManagerScript endVariable;
    public void Update()
    {
        LoadScene();
    }
    void LoadScene()
    {
        if (endVariable.gameEnd == true)
        {
            SceneManager.LoadScene("FinalScene");
            LoadSceneOptions();
        }
    }
    void LoadSceneOptions()
    {
        if (endVariable.gemAchieve == true && endVariable.gameEnd == false)
        {
            Debug.Log("Game Passed");
        } else 
        {
            Debug.Log("Game OVer");
        }
    }
}
