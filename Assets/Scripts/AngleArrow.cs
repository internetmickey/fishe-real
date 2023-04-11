using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public GameObject projectilePrefab;
    public Transform gunTip;
    public ScoreManager scoreManager;
    public float fireForce = 10.0f;

    // Update is called once per frame
    void Update()
    {


        //Keeps gun on player direction
        float playerInput = Input.GetAxis("Horizontal");

        if (playerInput < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (playerInput > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        //Fires Bullet
        if (Input.GetKeyDown(KeyCode.V))
        {
            FireGun();
        }
    }
    //Script for bullet fire
    void FireGun()
    {
        GameObject projectile = Instantiate(projectilePrefab, gunTip.position, transform.rotation);
        Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();

        if (transform.localRotation.eulerAngles.y == 0)
        {
            projectileRb.velocity = Vector2.left * fireForce;
        }
        else
        {
            projectileRb.velocity = Vector2.right * fireForce;
        }

        Destroy(projectile, 3.0f);
    }

    
}
