using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class PlayButtomScript : MonoBehaviour
{
    public float fadeDuration;
    void Start()
    {
        FadeOutAndLoadScene();
    }
    private void FadeOutAndLoadScene()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(0f,fadeDuration).OnComplete(LoadScene2);
    }
    private void LoadScene2()
    {
        SceneManager.LoadScene("MainScene");
    }
}
