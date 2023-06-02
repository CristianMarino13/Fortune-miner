using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlatformMovementScript : MonoBehaviour
{
    public Transform platform;  
    public Transform pointB;    
    public float duration; 

    private void Awake()
    {
        
        MovePlatform();
    }

    private void MovePlatform()
    {
        
        Tweener tweener = platform.DOMove(pointB.position, duration);

        
        tweener.SetLoops(-1, LoopType.Yoyo);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag ("Player"))
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.transform.SetParent(null);
    }
}
