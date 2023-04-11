using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player2Controller : MonoBehaviour
{
    public Rigidbody2D playerRb;
    
    public float speed = 15.0f;
    private Vector2 jumpForce = new Vector2(0, 33);

    //isGrounded
    public bool isGrounded;
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

        float playerInput = Input.GetAxis("Player 2 Horizontal");
        playerRb.AddForce(Vector2.right * speed * playerInput * Time.deltaTime);

        //Player jump script
        if (Input.GetKeyDown(KeyCode.Alpha4) && isGrounded == true)
        {
            playerRb.AddForce(jumpForce, ForceMode2D.Impulse);
        }

    }


}
