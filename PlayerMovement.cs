using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce; 

    public Joystick joystick;
    public Rigidbody2D rb;
    public GameObject deathEffect;

    public GameObject LoseMenu;
    public static bool isDead;

    public void FixedUpdate()
    {
        Vector2 direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);

        if(rb.rotation < 0.0001) 
        {
            rb.rotation = 0f;
        }

        if (rb.rotation > - 0.0001)
        {
            rb.rotation = 0f;
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
            isDead = true;
            LoseMenu.SetActive(true);
            Time.timeScale = 0.1f;
        }

        if (PauseMenu.startOver = true)
        {
            isDead = false;
        }
    }
}