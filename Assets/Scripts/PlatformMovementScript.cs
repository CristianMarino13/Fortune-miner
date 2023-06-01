using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlatformMovementScript : MonoBehaviour
{
    public Transform platform;  
    public Transform pointB;    
    public float duration; 

    private void Start()
    {
        
        MovePlatform();
    }

    private void MovePlatform()
    {
        
        Tweener tweener = platform.DOMove(pointB.position, duration);

        
        tweener.SetLoops(-1, LoopType.Yoyo);
    }
}
