using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private PlayerManagerScript endVariable;
    
    private GameObject lavafloor;
    public void  Awake()
    {
        lavafloor = GetComponent<GameObject>();
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Invoke("changeScene",2.0f);   
        }
    }
    public void changeScene()
    {
        SceneManager.LoadScene("FinalScene");
    }
}
