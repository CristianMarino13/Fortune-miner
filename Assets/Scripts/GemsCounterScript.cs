using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemsCounterScript : MonoBehaviour
{
    public Text gemText;
    private PlayerManagerScript playerManager;

    private void Update()
    {
        playerManager = GetComponent<PlayerManagerScript>();
        int numberOfGems = (playerManager.gemAchieve);
        gemText.text = "GEMS: "+ numberOfGems.ToString();
    }
    
}
