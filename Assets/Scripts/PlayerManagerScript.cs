using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerScript : MonoBehaviour
{


    [SerializeField] float speed;
    [SerializeField] bool isOnGround = true;
    
    [SerializeField] float jumpForce = 8f;
    public float gravityModifier;
    private GameObject player;
    private Rigidbody playerRb;
    public bool gameEnd = false;
    public bool gemAchieve = false;


    void Awake()
    {
        player = GetComponent<GameObject>();
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }


    void Update()
    {
        Movement(speed);

        
    }

    /// <summary>
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
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("StartPoint") )
        {
            isOnGround = true;
        } 
        else if(collision.gameObject.CompareTag("LavaFloor"))
        {
            gameEnd = true;
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("GemObject"))
        {
            gemAchieve = true;
            Destroy(gameObject);
        }
    }

}




