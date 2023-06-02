using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private PlayerManagerScript endVariable;

    private GameObject lavafloor;
    public bool endVerifier = true;
    public int delay;
    public void  Awake()
    {
        lavafloor = GetComponent<GameObject>();
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            endVerifier = false;
            Invoke("changeScene",delay);   
        }
    }
    
    public void changeScene()
    {
        SceneManager.LoadScene("FinalScene");
    }
}
