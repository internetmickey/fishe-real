using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRb;
    
    public float speed = 15.0f;
    private Vector2 jumpForce = new Vector2(0,33);

    //isGrounded
    private bool isGrounded;
    public LayerMask groundLayers;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //isGrounded check
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f, groundLayers);
        if (hit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        //Player movement
        float playerInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector2.right * speed * playerInput * Time.deltaTime);

        //Player jump script
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true) 
        { 
            playerRb.AddForce(jumpForce, ForceMode2D.Impulse);
        }

        
        

       
    }
    

}
