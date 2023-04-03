using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public TextMeshProUGUI debugGround;
    public float speed = 15.0f;
    private Vector2 jumpForce = new Vector2(0,15);

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
        isGrounded = Physics2D.OverlapArea(new Vector2((transform.position.x - 0.6f), (transform.position.y - 0.65f)), new Vector2((transform.position.x), (transform.position.y - .8f)), groundLayers);
        
        float playerInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector2.right * speed * playerInput * Time.deltaTime);

        //Player jump script
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true) 
        { 
            playerRb.AddForce(jumpForce, ForceMode2D.Impulse);
        }

        //isGrounded debug
        if (isGrounded== true)
        {
            debugGround.text = "Grounded";
        } else
        {
            debugGround.text = "Not Grounded";
        }

       
    }
  
}
