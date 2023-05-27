using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerScript : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] bool isOnGround = true;
    [SerializeField] float jumpForce = 8f;
    public float gravityModifier;

    private Rigidbody playerRb;


    void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }


    void Update()
    {
        Movement(speed);

        
    }

    /// <summary>
    /// move the party to the front,back, and sides at a certain speed
    /// </summary>
    /// <param name="speed"></param>
    public void Movement(float speed)
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRb.velocity = new Vector3(horizontalInput *speed, playerRb.velocity.y, verticalInput*speed) ;

        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            playerRb.velocity = new Vector3(playerRb.velocity.x, jumpForce, playerRb.velocity.y);
            isOnGround = false;

        }   
        
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform") )
        {
            isOnGround = true;
        }
    }

}




